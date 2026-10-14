using CAD.Api.Errors;
using CAD.Api.Realtime;
using CAD.Infrastructure;
using Microsoft.Extensions.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure();
builder.Services.AddHealthChecks();
builder.Services.AddProblemDetails();
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddSignalR(options => options.EnableDetailedErrors = false);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var allowedOrigins = builder.Configuration.GetSection("Cors:AllowedOrigins").Get<string[]>() ?? [];
if (allowedOrigins.Any(origin => origin.Contains('*') || !Uri.TryCreate(origin, UriKind.Absolute, out var uri)
    || (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps)
    || uri.GetLeftPart(UriPartial.Authority) != origin))
{
    throw new InvalidOperationException("Cors:AllowedOrigins debe contener orígenes HTTP/HTTPS exactos, sin rutas ni comodines.");
}

builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
{
    // Sin orígenes configurados no se habilita acceso cross-origin.
    if (allowedOrigins.Length > 0)
    {
        policy.WithOrigins(allowedOrigins).WithMethods("GET", "POST").WithHeaders("Content-Type");
    }
}));

var app = builder.Build();
app.UseExceptionHandler();
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
    app.UseHttpsRedirection();
}

app.UseCors();
app.MapGet("/health", async (HealthCheckService healthChecks, CancellationToken cancellationToken) =>
{
    var report = await healthChecks.CheckHealthAsync(cancellationToken);
    return Results.Text(report.Status.ToString(), "text/plain",
        statusCode: report.Status == HealthStatus.Unhealthy
            ? StatusCodes.Status503ServiceUnavailable
            : StatusCodes.Status200OK);
}).WithName("Health").WithTags("Infrastructure")
    .Produces<string>(StatusCodes.Status200OK, "text/plain")
    .Produces<string>(StatusCodes.Status503ServiceUnavailable, "text/plain");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    // Solo esqueleto de transporte; no exponer en producción antes de definir autorización.
    app.MapHub<CadHub>("/hubs/cad");
}

app.Run();

public partial class Program { }
