# Sistema CAD

Sistema Integrado de Monitoreo, Alertas Georreferenciadas y Despacho CAT para la Gestión de Seguridad Municipal, tipo B. MVP académico con datos simulados: SOS, reportes, despacho asistido y acompañamiento voluntario. No es un canal oficial de emergencias.

Arquitectura aprobada: tres interfaces React + TypeScript + Vite; Ciudadano y Sereno son PWA, Central es web. Backend ASP.NET Core Web API (.NET 10 LTS, soporte hasta noviembre de 2028) como monolito modular; PostgreSQL en Neon, EF Core/Npgsql, SignalR y Leaflet/OpenStreetMap. La aprobación sustituye MAUI/Razor Pages del plan propuesto, conservando los requisitos originales; véase [ADR-002](docs/architecture/decisions/0002-arquitectura-definitiva.md).

| Ruta | Organización |
|---|---|
| `apps/ciudadano`, `apps/sereno`, `apps/central` | Aplicaciones independientes, aún sin inicializar |
| `backend/src/CAD.Api/Modulos` | Cuentas, Casos, Despacho, Acompanamiento y Consultas |
| `backend/src/CAD.Infrastructure` | Persistencia e infraestructura compartida |
| `tests/CAD.UnitTests`, `tests/CAD.IntegrationTests`, `tests/CAD.LoadTests` | xUnit unitario/integración; carga reservada |
| `docs/requirements` | PDF originales, análisis y matriz de trazabilidad |
| `docs/architecture/decisions` | ADR vigentes; `docs/decisions` conserva la decisión histórica inicial |
| `docs/scrum`, `docs/api`, `docs/testing` | Flujo de trabajo y documentación futura |
| `infra/docker`, `.github/workflows` | Espacios para despliegue y CI futuros |

Estado: Etapa 2.2, backend inicial ejecutable sin historias de usuario, migrado a .NET 10 antes de la Etapa 2.3. Solución `backend/CAD.sln`: API, infraestructura y dos proyectos xUnit, todos `net10.0`. Sin frontend inicializado, entidades de negocio, autenticación, Neon o migraciones. Los módulos permanecen vacíos. Los PDF ya son legibles; el análisis contiene 34 RF operativos, 14 RNF y 43 HU. Los CA completos dependen de una fuente [HU] no adjunta; no se acredita implementación ni aceptación de historias.

Leer [AGENTS.md](AGENTS.md), [análisis](docs/requirements/analisis-requisitos.md), [matriz](docs/requirements/matriz-trazabilidad.md), [pendientes](docs/architecture/decisiones-pendientes.md) y [flujo Git](docs/scrum/flujo-git.md). El calendario original necesita revisión; no se han aprobado fechas nuevas. Codex implementa y valida; Claude Code gestiona exclusivamente Git/GitHub bajo autorización.

## Ejecutar el backend

Requisito: SDK .NET 10.0.401 o posterior de la línea 10.0, según `global.json` (`rollForward: latestFeature`). Comprueba con `dotnet --list-sdks`.

Si el `dotnet` del PATH es el de `C:\Program Files\dotnet` y solo tiene una versión anterior (por ejemplo .NET 8), responde «A compatible .NET SDK was not found». Cuando el SDK 10 esté instalado en el perfil del usuario (`%LOCALAPPDATA%\Microsoft\dotnet`), antepónlo al PATH **solo en la sesión actual de PowerShell**, sin cambiar la configuración global, y comprueba que `dotnet --version` muestre 10.0.4xx o posterior:

```powershell
$env:DOTNET_ROOT = "$env:LOCALAPPDATA\Microsoft\dotnet"
$env:PATH = "$env:DOTNET_ROOT;$env:PATH"
dotnet --version
```

Desde la raíz:

```powershell
dotnet restore backend/CAD.sln
dotnet build backend/CAD.sln --no-restore
dotnet test backend/CAD.sln --no-build
dotnet run --project backend/src/CAD.Api/CAD.Api.csproj --launch-profile CAD.Api
```

El perfil local usa `Development` y `http://localhost:5080`. `GET /health` devuelve `200`, texto `Healthy`: comprueba el proceso, sin verificar base de datos ni disponibilidad de negocio. Swagger UI está en `/swagger` y OpenAPI en `/swagger/v1/swagger.json`, solo en desarrollo. El hub vacío `/hubs/cad` y su negociación `POST /hubs/cad/negotiate` también se habilitan solo en desarrollo; no hay métodos ni eventos de negocio ni autorización de usuarios configurada.

CORS permite únicamente los orígenes locales explícitos `http://localhost:5173`, `:5174` y `:5175` en desarrollo, con GET/POST y Content-Type, sin credenciales cross-origin. La configuración base no permite ningún origen cross-origin. Estos puertos son convenciones locales, no requisitos ni frontends ya existentes. CORS no sustituye autenticación ni controla clientes que no son navegadores.

Las variables de entorno sobrescriben `appsettings`: `Cors__AllowedOrigins__0`, `AllowedHosts`, `ASPNETCORE_URLS` y `ASPNETCORE_ENVIRONMENT`. `.env.example` solo es una guía, no se carga automáticamente. Para ejecutar sin el perfil local:

```powershell
$env:ASPNETCORE_ENVIRONMENT = "Development"
$env:ASPNETCORE_URLS = "http://localhost:5080"
$env:Cors__AllowedOrigins__0 = "http://localhost:5173"
dotnet run --project backend/src/CAD.Api/CAD.Api.csproj --no-launch-profile
```

En producción se exige configurar hosts, orígenes exactos y HTTPS; se aplican redirección HTTPS y HSTS. Swagger y el hub de prueba no se publican. Las excepciones generan ProblemDetails 500 con identificador de traza, sin mensaje ni stack sensibles; el logging automático de excepciones del middleware está suprimido y el handler registra solo tipo e identificador. Manejo y pruebas de integración siguen [la guía de ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-10.0) y [WebApplicationFactory](https://learn.microsoft.com/en-us/aspnet/core/test/integration-tests?view=aspnetcore-10.0).

CI: GitHub Actions aún no está configurado (`.github/workflows` vacío). Cuando se configure, el workflow deberá instalar el SDK .NET 10 indicado en `global.json` (por ejemplo, `actions/setup-dotnet` con `global-json-file: global.json`) antes de restaurar, compilar y probar; los runners pueden no incluir esa versión.
