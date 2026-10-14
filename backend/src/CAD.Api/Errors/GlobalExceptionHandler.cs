using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace CAD.Api.Errors;

public sealed class GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger) : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        // No registrar el mensaje, cuerpo ni stack de la excepción: pueden contener datos sensibles.
        logger.LogError("Error no controlado de tipo {ExceptionType}. TraceId: {TraceId}",
            exception.GetType().Name, httpContext.TraceIdentifier);

        httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        var problem = new ProblemDetails
        {
            Status = StatusCodes.Status500InternalServerError,
            Title = "Error interno del servidor",
            Extensions = { ["traceId"] = httpContext.TraceIdentifier }
        };
        await httpContext.Response.WriteAsJsonAsync(problem, options: (System.Text.Json.JsonSerializerOptions?)null,
            contentType: "application/problem+json", cancellationToken: cancellationToken);
        return true;
    }
}
