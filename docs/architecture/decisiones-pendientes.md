# Decisiones pendientes del Sistema CAD

## Aprobado y resuelto

React/TypeScript/Vite (dos PWA y Central web), API .NET 10 LTS (aprobada inicialmente como .NET 8 y migrada antes de la Etapa 2.3), monolito modular por funcionalidades, Neon/PostgreSQL, EF Core/Npgsql, SignalR y Leaflet/OpenStreetMap están **aprobados por el responsable**, no pendientes: [ADR-002](decisions/0002-arquitectura-definitiva.md). No son obligaciones tecnológicas textuales de los PDF.

La lectura de los PDF está resuelta con Poppler 25.07.0. El anterior registro local DP-01–DP-04 era un listado de bloqueos/validaciones propio del repositorio: **no corresponde a DP01–DP22 de las fuentes**. Se sustituye por este registro; lectura cerrada, trazabilidad recuperada y aprobación de stack registrada. No acredita aceptación de HU ni aprobación íntegra del análisis.

## DP originales citadas en los PDF

Identificadores conservados. SCR cita DP sin un catálogo completo de definiciones; ARQ §1.9 pp.8–9 identifica temas solo cuando inferibles de [HU]/SCR y los demás como no inferibles. Tratamientos sugeridos por ARQ (semilla, políticas, parámetros) **no son decisiones de negocio aprobadas**. Todas las DP siguientes siguen abiertas salvo aprobación explícita futura. [HU] original no está adjunto.

| DP original | Tema verificable | Impacto / referencia |
|---|---|---|
| DP01 | Datos del registro y obligatoriedad de teléfono | HU01/HU12; ARQ §1.9 p.8; previa Sprint 1, SCR §4.1 p.34 |
| DP02 | Alta inicial de administradores | HU02/HU04; ARQ §1.9 p.8; previa Sprint 1, SCR p.34. Semilla de ARQ es supuesto, no autorización |
| DP03 | Cuenta desactivada con sesión abierta o asignación vigente | HU05-CA04; ARQ §1.9 p.8; Sprint 4, SCR pp.35,39 |
| DP04 | Qué significa operador autorizado | HU03/HU33/HU38/HU39; ARQ §1.9 p.8; permisos desde Sprint 1, SCR pp.17,34 |
| DP05 | Visibilidad ciudadana de estado, descarte y resultado | HU17/HU24/HU30/HU31; ARQ §1.9 p.8; Sprints 2–3, SCR p.34 |
| DP06 | Datos de caso visibles para sereno | HU21-CA05; ARQ §1.9 p.8; Sprint 2, SCR p.34 |
| DP07 | Catálogo de categorías | HU10/HU13/HU14/HU24/HU26; ARQ §1.9 p.8; Sprint 2, SCR p.34 |
| DP08 | No inferible con certeza | ARQ §1.9 p.9; Sprint 3, SCR p.34 |
| DP09 | Quién clasifica SOS | HU13; ARQ §1.9 p.8; Sprint 2, SCR p.34 |
| DP10 | Referencia textual en el mapa | HU12/HU25; ARQ §1.9 p.8; Sprints 2–4, SCR pp.34–35 |
| DP11 | No inferible con certeza | ARQ §1.9 p.9; previa Sprint 1, SCR p.34 |
| DP12 | No inferible con certeza | ARQ §1.9 p.9; Sprints 4–5, SCR p.35 |
| DP13 | No inferible con certeza | ARQ §1.9 p.9; Sprint 4, SCR p.39 |
| DP14 | No inferible con certeza; ARQ D9 sugiere posible relación con SOS vigente, sin confirmarla | ARQ §1.9 p.9 y D9 p.7; previa Sprint 1, SCR p.34; Sprint 5 p.35 |
| DP15 | No inferible con certeza; ARQ §1.5 solo sugiere posible intervalo del sereno | ARQ pp.6,9; Sprint 2, SCR p.34. No fijar valor |
| DP16 | Sereno sin GPS o desactivado con asignación vigente | HU18; ARQ §1.9 p.8; Sprint 2, SCR p.34 |
| DP17 | No inferible con certeza | ARQ §1.9 p.9; Sprints 3/5, SCR pp.34–35 |
| DP18 | No inferible con certeza | ARQ §1.9 p.9; Sprint 5, SCR p.35 |
| DP19 | Origen y estado del caso urgente creado desde aviso | HU43-CA05; ARQ §1.9 p.8; SCR S5-T09 p.29. Criterio queda pendiente |
| DP20 | Cierre sin conexión y solicitudes simultáneas de bienestar | HU36-CA03/HU40-CA04/HU42-CA05; ARQ §1.9 p.8; Sprints 4–5, SCR p.35 |
| DP21 | No inferible con certeza | ARQ §1.9 p.9; Sprint 3, SCR p.34; aceptación HU20-B, SCR §3.3 p.32 |
| DP22 | Plazo de recorridos y condiciones de conservación/eliminación | HU39/RNF13; ARQ §1.9 p.8, §9.9 p.45; SCR §3.1 p.13, §3.3 p.32. HU39-B/RNF13 bloqueados |

## Puerta de entrada al Sprint 1

SCR §4.1 p.34 y §5 p.38 exige resolver o documentar DP01/DP02/DP04/DP11/DP14 y acordar capacidad/disponibilidad. Aprobar TEC01 y SPIKE01, incluido su límite provisional de dos días de trabajo; SPIKE01 debe definir condiciones validadas de GPS y posible reestimación de HU18/HU35 (SCR S1-T03/T04 p.17). HU07/HU08 tienen aceptación conjunta; HU03 queda abierta hasta comprobar operaciones HU04–HU43 (SCR §3.3 p.31). La aprobación del stack no cierra estas condiciones.

## Pendientes propios del proyecto (PROY, no DP de las fuentes)

| ID local | Decisión / evidencia necesaria | Responsable de validación |
|---|---|---|
| PROY-01 | Conseguir historias [HU] originales con CA completos y definición formal de DP; confirmar correspondencias RF propuestas del Anexo A y cobertura RF de HU39 | Responsable de requisitos / PO |
| PROY-02 | Aprobar divisiones HU20/HU39, componente de mapa temprano y criterios citados de cancelación. ARQ D3 p.7 y SCR §3.1 pp.11–13 muestran diferencias de orden/aceptación | PO / equipo |
| PROY-03 | Replanificar calendario y capacidad; SCR §4.5/§5 pp.37–39 y ARQ D13 p.8 no prueban avance real. Sin fechas nuevas ni SP acreditados | PO / equipo |
| PROY-04 | Elegir proveedor frontend/backend y entorno que cumpla RNF02/03/10 frente a suspensión y arranque en frío; presupuestos/planes no aprobados por elegir Neon | Responsable / equipo |
| PROY-05 | Concretar autenticación y sesión de las tres interfaces, CORS y seguridad de hubs; versiones de paquetes compatibles con .NET 10 (versión y soporte resueltos en ADR-002); modelos/mapeos EF sin ciclo Api↔Infrastructure | Arquitectura / equipo, antes de implementar esos componentes |
| PROY-06 | Obtener evidencia de RNF04/05/07/11/12/13 en navegador, carga RNF02/03 y monitor RNF10; definir herramientas y procedimiento de pruebas | QA / equipo |
| PROY-07 | Confirmar exclusión de telefonía/ruteo/cercanía automática y estados SOS vigentes; no convertir propuestas D4–D6/D9 de ARQ p.7 en nuevas reglas sin revisar | PO |

Las revisiones de textos/diagramas de implementación dependientes de MAUI/Razor quedan pendientes sin modificar los PDF. Las recomendaciones técnicas no modifican silenciosamente el alcance funcional.
