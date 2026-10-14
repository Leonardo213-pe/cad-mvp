# ADR-002 — Arquitectura definitiva React + ASP.NET Core + Neon

Estado: **Aceptada por el responsable del proyecto**, mediante instrucción de la Etapa 2.1C. Es una decisión aprobada de implementación, **no una obligación textual de los PDF**. Sustituye las propuestas incompatibles de [DT-001](../../decisions/0001-estructura-inicial.md) y del Plan de Arquitectura; no modifica RF/RNF ni resuelve automáticamente las DP.

## Contexto y decisión

SCR §1.4/§1.5 pp.2,8 propone dos PWA y un panel web; ARQ §3/§4 pp.12–17 y §10.6 pp.49–50 propone una app MAUI 10 con modos ciudadano/sereno, panel Razor Pages y ASP.NET Core 10. Se necesita una única decisión antes de crear proyectos ejecutables.

| Componente | Tecnología aprobada |
|---|---|
| Ciudadano | React + TypeScript + Vite, PWA independiente |
| Sereno | React + TypeScript + Vite, PWA independiente |
| Central | React + TypeScript + Vite, aplicación web independiente |
| Backend | ASP.NET Core Web API, .NET 8; monolito modular por funcionalidades |
| Base de datos / persistencia | PostgreSQL administrado en Neon; EF Core + Npgsql |
| Tiempo real / mapas | SignalR; Leaflet + OpenStreetMap |

Un único backend con módulos Cuentas, Casos, Despacho, Acompanamiento y Consultas en `CAD.Api/Modulos`, e infraestructura compartida en `CAD.Infrastructure`. Los módulos podrán organizar Dominio/Aplicacion/Endpoints internamente; no se imponen cuatro proyectos horizontales. Carpetas no equivalen a microservicios ni a proyectos ya creados.

## Justificación

Las PWA respetan SCR y RNF04 en píxeles CSS; interfaces por actor permiten desarrollar y probar flujos por HU, con autorización efectiva en servidor. Un solo backend reduce despliegues y coordinación transaccional para un equipo de tres personas y 20 sesiones (ARQ §1.4/§1.5 pp.5–6, §10.1 p.48). Favorece integración incremental y despliegue académico; el cumplimiento de RNF requiere pruebas, no se deduce de esta elección.

## Dependencias y persistencia

- EF Core es el mecanismo de persistencia. La aplicación de los módulos puede utilizar `CadDbContext` de `CAD.Infrastructure` sin repositorios genéricos obligatorios, mediadores ni interfaces por entidad (coherente con ARQ §3.4–§3.7 pp.13–14).
- `CAD.Api` puede depender de `CAD.Infrastructure`; Infrastructure no referencia Api. Evitar ciclos también entre módulos.
- Dominio mantiene invariantes y reglas separado de EF Core, transporte y SignalR. Como las entidades de dominio estarán dentro de Api, Infrastructure no debe requerir esos tipos: al crear proyectos se deberá concretar persistencia con modelos propios y mapeo desde la aplicación, o una alternativa mínima explícitamente revisada que mantenga la dirección. **No se crea ahora un proyecto de dominio/contratos por anticipación**.
- Endpoints y hubs delegan las escrituras a aplicación; Consultas usa lecturas/proyecciones sin escrituras. Acceso a otro módulo mediante operaciones públicas/contratos; no modificar directamente entidades internas ajenas.
- Confirmar las operaciones y su historial en una transacción, emitir eventos después y resincronizar clientes al reconectar. PostgreSQL conserva estado; SignalR no sustituye persistencia. Implementar idempotencia/concurrencia para RNF08 sin abstraer por defecto la unidad de trabajo de EF Core.

## Consecuencias y pendientes

Se descarta MAUI para el MVP y Razor Pages como interfaz principal de Central. También se sustituye la versión .NET 10 propuesta por .NET 8. No se cambian los PDF: sus diagramas/unidades desplegables, contratos C# compartidos con móvil y autenticación cookie/JWT ligada a esos clientes deben adaptarse en documentación de implementación futura. RNF04 permanece en CSS y RNF05 conserva Firefox.

Tres interfaces requieren definir publicación, CORS, sesión/tokens y protección de solicitudes por navegador. Esos detalles no quedan aprobados por elegir React. GPS/despacho se validan con app visible y conexión disponible; no se promete segundo plano, push con app cerrada ni ruteo. RNF02/03/10 requieren pruebas reales en el entorno elegido; Neon no garantiza su cumplimiento por sí solo.

Aún deben elegirse versiones compatibles de paquetes EF Core/Npgsql/frontend, mecanismo de autenticación, modelos/mapeos de persistencia, proveedor de frontend/backend y condiciones de disponibilidad. Revisar soporte de versiones antes de implementar. RNF13/HU39-B siguen bloqueados por DP22; no se introduce un plazo de retención. Calendario, DP y evidencias pendientes en [decisiones-pendientes.md](../decisiones-pendientes.md).

Fuentes: [SCR](../../requirements/Plan_Scrum_Sistema_Integrado_CAD_-_actualizado.pdf), [ARQ](../../requirements/Plan_de_Arquitectura_Sistema_Integrado_CAD.pdf), [análisis](../../requirements/analisis-requisitos.md). Los ADR-01–05 dentro del PDF ARQ son propuestas de esa fuente; ADR-002 de este repositorio es un registro distinto.
