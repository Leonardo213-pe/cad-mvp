using System.Text.Json;
using CAD.Api.Errors;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;

namespace CAD.UnitTests;

public sealed class GlobalExceptionHandlerTests
{
    [Fact]
    public async Task UnexpectedExceptionReturnsProblemDetailsWithoutSensitiveInformation()
    {
        using var services = new ServiceCollection().BuildServiceProvider();
        var context = new DefaultHttpContext { RequestServices = services, TraceIdentifier = "test-trace" };
        await using var body = new MemoryStream();
        context.Response.Body = body;
        var handler = new GlobalExceptionHandler(NullLogger<GlobalExceptionHandler>.Instance);

        var handled = await handler.TryHandleAsync(context,
            new InvalidOperationException("SENSITIVE_TEST_MARKER"), CancellationToken.None);

        Assert.True(handled);
        Assert.Equal(StatusCodes.Status500InternalServerError, context.Response.StatusCode);
        Assert.StartsWith("application/problem+json", context.Response.ContentType);
        body.Position = 0;
        using var document = await JsonDocument.ParseAsync(body);
        Assert.Equal(500, document.RootElement.GetProperty("status").GetInt32());
        Assert.Equal("test-trace", document.RootElement.GetProperty("traceId").GetString());
        Assert.DoesNotContain("SENSITIVE_TEST_MARKER", document.RootElement.GetRawText());
        Assert.False(document.RootElement.TryGetProperty("stackTrace", out _));
    }
}
