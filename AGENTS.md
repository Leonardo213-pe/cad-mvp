# Reglas compartidas del Sistema CAD

## Fuentes y alcance
- Leer los PDF originales, [análisis](docs/requirements/analisis-requisitos.md), [matriz](docs/requirements/matriz-trazabilidad.md) y [ADR-002](docs/architecture/decisions/0002-arquitectura-definitiva.md) antes de implementar.
- Conservar IDs RF/RNF/HU y citar documento, sección y página. Distinguir requisitos, propuestas documentales, decisiones aprobadas e inferencias; no inventar CA ni resolver DP sin autorización.
- MVP académico con datos y coordenadas simulados; sin integración real de emergencias, despacho automático ni ruteo complejo. Respetar el alcance autorizado de cada etapa.
- Crear proyectos e instalar dependencias cuando la etapa lo autorice; las restricciones temporales pertenecen a su prompt. No avanzar a otra etapa por iniciativa propia.

## Arquitectura aprobada
- Ciudadano y Sereno: aplicaciones independientes React + TypeScript + Vite, PWA. Central: React + TypeScript + Vite, web.
- Backend: ASP.NET Core Web API .NET 10 LTS (SDK según `global.json`), un monolito modular por funcionalidades en `backend/src/CAD.Api/Modulos/{Cuentas,Casos,Despacho,Acompanamiento,Consultas}`; infraestructura compartida en `CAD.Infrastructure`.
- PostgreSQL administrado en Neon; EF Core + Npgsql; tiempo real SignalR; mapas Leaflet/OpenStreetMap. No reemplazar estas decisiones sin aprobación y ADR.
- No imponer proyectos horizontales Domain/Application. Los módulos pueden organizar internamente Dominio, Aplicacion y Endpoints según necesidad.
- Aplicacion puede usar `CadDbContext` de Infrastructure; no crear repositorios genéricos por defecto. Infrastructure no depende de Api. Dominio no depende de EF Core, ASP.NET Core o SignalR. Evitar ciclos.
- Entre módulos, usar operaciones públicas/contratos; no modificar entidades internas ajenas. Contratos compartidos solo si una necesidad real evita un ciclo; no añadir proyectos, mediadores o abstracciones por anticipación.
- Endpoints/hubs delegan escrituras a casos de uso; Consultas no escribe. El estado persistido es la referencia; publicar eventos tras confirmar y recuperar estado al reconectar. Detalles en ADR-002.

## Seguridad y GPS
- Autorización en servidor por rol y titularidad; comprobar solicitudes directas, acceso a hubs/grupos y casos propios. El nombre de una app no concede permisos.
- Hash específico de contraseñas, configuración documentada; HTTPS/WSS y conexión cifrada a la base. Nunca registrar contraseñas, tokens, cuerpos sensibles, teléfonos, notas ni coordenadas/recorridos.
- GPS ciudadano solo en SOS, reporte por elección o acompañamiento explícito activo. Abrir app o conceder permiso no transmite posiciones ni activa sesión. Detener captura/envío al finalizar o vencer.
- Mostrar estado, tiempo restante y problemas reales; no prometer cobertura en segundo plano ni con app cerrada. Conservar límites de RNF11 y probar privacidad RNF07/12/13.
- No fijar retención sin DP22; restringir recorridos, registrar finalidad de excepciones y evitar datos reales en pruebas/demostraciones.
- Secretos fuera del repositorio, en entorno/servicio de secretos. `.env.example` solo valores vacíos/ficticios. No publicar credenciales ni activar logs sensibles de EF Core; revisar cambios antes de compartir.

## Convenciones y pruebas
- UTF-8, LF y espacios según `.editorconfig`/`.gitattributes`. Documentación breve en español con enlaces; evitar duplicar catálogos.
- C#: PascalCase para tipos/métodos, camelCase para variables/parámetros; TypeScript estricto al configurar proyectos, sin `any` injustificado. Mantener nombres y estructura del módulo, cambios pequeños y revisables.
- Validar entradas en servidor, reglas de estado/dominio y conflictos concurrentes. No confundir validaciones UI con controles de seguridad.
- Pruebas unitarias en `tests/CAD.UnitTests`, integración en `tests/CAD.IntegrationTests`, carga en `tests/CAD.LoadTests`. Elegir herramientas cuando se creen proyectos; probar comportamiento y riesgos, no reflejar cada detalle de implementación.
- RNF02/03 requieren carga: ≥100 SOS/20 sesiones con ≥95% ≤3 s; 30 min/20 sesiones/≥5 acompañamientos, sin pérdidas ni inconsistencia. RNF10 requiere monitor separado de 8 h. No afirmar cumplimiento sin evidencia.
- Conservar verificación acumulativa de HU03 y relaciones de aceptación; “implementada” no equivale a “aceptada” ni “liberada”.

## Trabajo y Git
- Codex implementa código/documentación y valida; Claude Code se encarga exclusivamente de las operaciones de Git/GitHub que cambian estado o publican (ramas, staging, commits, push, PR y merges), dentro de la autorización del responsable.
- Codex puede consultar `status`, `diff`, `log` y referencias para verificar trabajo; no realiza operaciones Git de escritura/publicación.
- `main` estable; `develop` integración; crear `feature/*` desde develop y revisar mediante PR hacia develop. Promoción de develop a main por PR aprobado. Sin merges automáticos, force push ni reescritura de historial.
- No descartar trabajo ajeno. Revisar rama y estado antes de editar; detenerse ante cambios ajenos que interfieran. Flujo detallado en [docs/scrum/flujo-git.md](docs/scrum/flujo-git.md).
