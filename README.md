# Sistema CAD

Sistema Integrado de Monitoreo, Alertas Georreferenciadas y Despacho CAT. Este monorepositorio contiene únicamente la estructura inicial; aún no hay aplicaciones, proyectos compilables ni instrucciones de ejecución.

| Ruta | Propósito reservado |
|---|---|
| `apps/ciudadano`, `apps/sereno`, `apps/central` | Interfaces futuras |
| `backend/src/CAD.{Api,Application,Domain,Infrastructure}` | Capas propuestas del backend |
| `tests/CAD.UnitTests`, `tests/CAD.IntegrationTests` | Pruebas futuras |
| `docs/{requirements,architecture,decisions,scrum,api,testing}` | Fuentes, análisis y documentación |
| `infra/docker` | Configuración futura de contenedores |
| `.github/workflows` | Automatización futura |

Las carpetas vacías usan `.gitkeep` para conservarlas en Git. Consulta [AGENTS.md](AGENTS.md) y las [decisiones propuestas](docs/decisions/0001-estructura-inicial.md).

Los PDF originales están en `docs/requirements/`. El [análisis disponible](docs/requirements/analisis-requisitos.md) está incompleto: no se ha verificado su contenido ni consta aprobación. La estructura autorizada por el usuario no acredita compatibilidad con los requisitos del MVP.
