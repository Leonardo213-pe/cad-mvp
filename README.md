# Sistema CAD

Sistema Integrado de Monitoreo, Alertas Georreferenciadas y Despacho CAT para la Gestión de Seguridad Municipal, tipo B. MVP académico con datos simulados: SOS, reportes, despacho asistido y acompañamiento voluntario. No es un canal oficial de emergencias.

Arquitectura aprobada: tres interfaces React + TypeScript + Vite; Ciudadano y Sereno son PWA, Central es web. Backend ASP.NET Core Web API (.NET 8) como monolito modular; PostgreSQL en Neon, EF Core/Npgsql, SignalR y Leaflet/OpenStreetMap. La aprobación sustituye MAUI/Razor Pages y .NET 10 del plan propuesto, conservando los requisitos originales; véase [ADR-002](docs/architecture/decisions/0002-arquitectura-definitiva.md).

| Ruta | Organización |
|---|---|
| `apps/ciudadano`, `apps/sereno`, `apps/central` | Aplicaciones independientes, aún sin inicializar |
| `backend/src/CAD.Api/Modulos` | Cuentas, Casos, Despacho, Acompanamiento y Consultas |
| `backend/src/CAD.Infrastructure` | Persistencia e infraestructura compartida |
| `tests/CAD.UnitTests`, `tests/CAD.IntegrationTests`, `tests/CAD.LoadTests` | Espacios reservados de pruebas |
| `docs/requirements` | PDF originales, análisis y matriz de trazabilidad |
| `docs/architecture/decisions` | ADR vigentes; `docs/decisions` conserva la decisión histórica inicial |
| `docs/scrum`, `docs/api`, `docs/testing` | Flujo de trabajo y documentación futura |
| `infra/docker`, `.github/workflows` | Espacios para despliegue y CI futuros |

Estado: Etapa 2.1C, estructura y documentación en revisión. Sin proyectos .NET/React, código funcional ni comandos de ejecución. Los `.gitkeep` preservan carpetas vacías. Los PDF ya son legibles; el análisis contiene 34 RF operativos, 14 RNF y 43 HU. Los CA completos dependen de una fuente [HU] no adjunta; no se acredita implementación ni aceptación.

Leer [AGENTS.md](AGENTS.md), [análisis](docs/requirements/analisis-requisitos.md), [matriz](docs/requirements/matriz-trazabilidad.md), [pendientes](docs/architecture/decisiones-pendientes.md) y [flujo Git](docs/scrum/flujo-git.md). El calendario original necesita revisión; no se han aprobado fechas nuevas. Codex implementa y valida; Claude Code gestiona exclusivamente Git/GitHub bajo autorización.
