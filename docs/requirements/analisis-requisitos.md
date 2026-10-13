# Análisis de requisitos del Sistema CAD

Estado: **incompleto; contenido de los PDF no verificable**. Fecha: 2026-10-13.

## Fuentes identificadas

| Clave local | Documento en esta carpeta | Tamaño verificado |
|---|---|---|
| ARQ | Plan_de_Arquitectura_Sistema_Integrado_CAD.pdf | 5 697 765 bytes |
| SCR | Plan_Scrum_Sistema_Integrado_CAD_-_actualizado.pdf | 845 830 bytes |

Las claves son referencias locales a documentos, no identificadores de requisitos. Se verificó la existencia de ambos archivos, pero no se recuperó su contenido. Los nombres no prueban alcance, versión aprobada ni tecnología. Se intentó lectura con Word en modo de solo lectura y Acrobat; Word no devolvió texto y Acrobat rechazó su interfaz COM (E_NOINTERFACE). No se instalaron dependencias ni se guardaron cambios en los PDF.

## Cobertura y límites

| Aspecto solicitado | Resultado verificable | Referencia pendiente |
|---|---|---|
| Requisitos funcionales | No verificable; no se asignan identificadores ni funcionalidades | ARQ/SCR: requisito, sección y página |
| Requisitos no funcionales | No verificable; no se establecen métricas de aceptación | ARQ/SCR: requisito, sección y página |
| Actores y permisos | No verificable; no se infieren roles del nombre CAD | ARQ/SCR: actor, operación, sección y página |
| Historias del Product Backlog | No verificable; no se han extraído historias ni criterios de aceptación | SCR: HU original, sección y página |
| Dependencias entre historias y sprints | No verificable; no se propone un orden de implementación sin backlog | SCR: HU, sprint, sección y página |
| Reglas de negocio, restricciones y exclusiones | No verificable; ausencia de evidencia no equivale a ausencia de reglas | ARQ/SCR: identificador si existe, sección y página |
| Contradicciones y ambigüedades | No evaluables sin leer y contrastar ambas fuentes | ARQ y SCR: pasajes correspondientes |
| Compatibilidad de arquitectura con MVP | **Indeterminada**; no se conoce arquitectura propuesta ni frontera del MVP | ARQ: arquitectura; SCR: alcance y sprints; secciones y páginas |

No hay requisitos documentados confirmados en este análisis. Tampoco hay base para afirmar que los documentos carezcan de requisitos. Las decisiones sobre cómo recuperar y validar las fuentes están en [decisiones-pendientes.md](../architecture/decisiones-pendientes.md); la cobertura de trazabilidad está en [matriz-trazabilidad.md](matriz-trazabilidad.md).

## Recomendación técnica, no requisito

Recuperar texto con delimitación de páginas y revisar tablas, diagramas y criterios de aceptación contra los PDF originales antes de planificar incrementos. Al completar la lectura, conservar los identificadores originales y distinguir dependencias explícitas de dependencias inferidas. Esta recomendación no prescribe tecnologías, actores ni funcionalidades del Sistema CAD.
