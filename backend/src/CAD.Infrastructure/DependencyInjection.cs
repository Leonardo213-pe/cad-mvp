using Microsoft.Extensions.DependencyInjection;

namespace CAD.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // Punto de composición reservado; sin base de datos ni servicios ficticios.
        return services;
    }
}
