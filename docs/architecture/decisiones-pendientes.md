# Decisiones pendientes

Estado: **no es posible evaluar las decisiones de dominio o arquitectura sin recuperar los PDF**. Fuentes y limitación en [análisis de requisitos](../requirements/analisis-requisitos.md).

Los identificadores DP son propios de este registro, no requisitos del Sistema CAD. No se han demostrado contradicciones entre documentos.

| ID | Decisión o validación pendiente | Evidencia actual / referencia faltante | Riesgo | Aprobación o validación necesaria |
|---|---|---|---|---|
| DP-01 | Elegir una vía de lectura verificable: texto exportado con páginas o acceso a un extractor existente que funcione | ARQ/SCR existen; extracción fallida. Secciones, requisitos y HU no verificables | Atribuir requisitos inexistentes o perder tablas y diagramas | Usuario: habilitar acceso a contenido legible; instalar herramientas requeriría autorización separada |
| DP-02 | Confirmar versiones vigentes y precedencia si las fuentes discrepan | El nombre de SCR contiene «actualizado»; no prueba aprobación. Sección de control de versiones no verificable | Resolver diferencias usando una versión no aprobada | Responsable de requisitos: confirmar fuentes normativas después de leerlas |
| DP-03 | Validar frontera del MVP, historias incluidas, criterios de aceptación y asignación a sprints | ARQ/SCR: HU, requisitos y secciones no verificables | Plan incremental basado en alcance supuesto | Responsable del producto: validar alcance extraído; pendiente, no se propone alcance nuevo |
| DP-04 | Validar compatibilidad de arquitectura con MVP y separar obligaciones de recomendaciones | ARQ: componentes y restricciones; SCR: historias y sprints; secciones no verificables | Adoptar complejidad innecesaria u omitir capacidades requeridas | Responsables de arquitectura y producto: revisar evaluación sustentada cuando se recuperen las fuentes |

DP-01 bloquea el análisis sustantivo; DP-02 a DP-04 son validaciones recomendadas, no ambigüedades documentales ya constatadas. No se requieren decisiones sobre tecnologías concretas con la evidencia disponible. No iniciar implementación basándose en estos documentos incompletos.
