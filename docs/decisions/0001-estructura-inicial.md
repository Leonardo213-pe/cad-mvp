# DT-001: estructura inicial del monorepositorio

Estado: estructura solicitada autorizada; decisiones de implementación propuestas, pendientes de validación. Fecha: 2026-10-13.

Origen: instrucción del usuario para crear únicamente el esqueleto del repositorio. No es una decisión extraída de los PDF ni acredita requisitos funcionales.

| Decisión | Estado / motivo |
|---|---|
| Un monorepositorio con tres espacios de apps, cuatro capas backend y dos espacios de pruebas | Estructura autorizada; facilita desarrollo incremental sin crear proyectos |
| Domain independiente; Application → Domain; Infrastructure → Application/Domain; Api como punto de composición | Propuesta técnica; evita acoplar dominio a transporte y persistencia |
| `AGENTS.md` como reglas compartidas; `CLAUDE.md` como referencia | Adoptado para evitar duplicación |
| `.gitkeep` en directorios vacíos | Adoptado porque Git conserva archivos, no carpetas vacías |
| UTF-8, LF, espacios: dos por defecto y cuatro en C# | Convención inicial, modificable al adoptar herramientas |

Pendientes: validar capas contra arquitectura original y MVP; seleccionar versiones de .NET/Node, framework de interfaces, base de datos, herramientas de pruebas, ejecución con contenedores y CI. No se seleccionan React ni PostgreSQL por inferencia a partir de las restricciones del usuario.

Fuentes pendientes de verificación: [plan de arquitectura](../requirements/Plan_de_Arquitectura_Sistema_Integrado_CAD.pdf) y [plan Scrum](../requirements/Plan_Scrum_Sistema_Integrado_CAD_-_actualizado.pdf). Requisitos/HU/secciones: **no verificables**. El [análisis existente](../requirements/analisis-requisitos.md) está incompleto y no consta aprobación. Conservar sus [pendientes](../architecture/decisiones-pendientes.md) sin duplicarlos aquí.
