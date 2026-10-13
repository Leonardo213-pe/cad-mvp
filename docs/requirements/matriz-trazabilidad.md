# Matriz de trazabilidad del Sistema CAD

Fuentes: **SCR** = [Plan Scrum](Plan_Scrum_Sistema_Integrado_CAD_-_actualizado.pdf), 39 páginas; **ARQ** = [Plan de Arquitectura](Plan_de_Arquitectura_Sistema_Integrado_CAD.pdf), 68 páginas. Las páginas son posiciones físicas del PDF (incluida portada). Estado de implementación: ninguno de estos requisitos/HU está implementado; esta etapa solo corrige documentación.

Se conservan 34 RF operativos de SCR (23 grupos), 14 RNF y 43 HU originales. No se cuentan cabeceras RF ni divisiones A/B como requisitos/historias adicionales. ARQ §0.2 p.4 y Anexo A pp.58–59 explican la numeración plana RF01–RF34 de la fuente [HU], que no está adjunta. **Las relaciones RF↔HU de ese anexo son propuestas documentadas por contenido, pendientes de confirmación**, no equivalencias normativas aprobadas. Los alias planos se muestran entre paréntesis para evitar confundir, por ejemplo, RF02 de SCR con RF02 de [HU].

Sprint previsto significa selección tentativa de SCR §3.1 pp.10–14; no compromiso, fecha nueva ni prueba de ejecución. Las referencias a criterios CA citadas por los PDF no sustituyen el documento original completo de historias.

## Requisitos funcionales

| ID | Descripción resumida | Fuente | HU relacionada | Sprint previsto | Estado |
|---|---|---|---|---|---|
| RF01.1 | Registro ciudadano con datos obligatorios (alias [HU]: RF01) | SCR §1.5 p.3; ARQ Anexo A p.58 | HU01 | 1 | Documentado; vínculo propuesto |
| RF01.2 | Inicio de sesión y acceso según rol (alias [HU]: RF02) | SCR §1.5 p.3; ARQ Anexo A p.58 | HU02 | 1 | Documentado; vínculo propuesto |
| RF02 | Autorización de operaciones e información por rol (alias [HU]: RF03) | SCR §1.5 p.3; ARQ Anexo A p.58 | HU03 | 1–5 | Documentado; vínculo propuesto |
| RF03.1 | SOS urgente independiente, sin categoría ni descripción (alias [HU]: RF04) | SCR §1.5 p.3; ARQ Anexo A p.58 | HU07 | 1 | Documentado; vínculo propuesto |
| RF03.2 | Ubicación actual del SOS; registrar aunque no esté disponible (alias [HU]: RF05) | SCR §1.5 p.4; ARQ Anexo A p.58 | HU08 | 1 | Documentado; vínculo propuesto |
| RF03.3 | Cancelar SOS propio pendiente con motivo (alias [HU]: RF21) | SCR §1.5 p.4; ARQ Anexo A p.58 | HU09 | 5 | Documentado; vínculo propuesto |
| RF04 | Comprobar, explicar y solicitar permiso GPS; posición inicial (alias [HU]: RF22) | SCR §1.5 p.4; ARQ Anexo A p.58 | HU06 | 1 | Documentado; vínculo propuesto |
| RF05.1 | Recepción de SOS en sección urgente separada (alias [HU]: RF06) | SCR §1.5 p.4; ARQ Anexo A p.58 | HU11 | 1 | Documentado; vínculo propuesto |
| RF05.2 | Mapa de SOS y reportes con ubicación válida, origen y estado (alias [HU]: RF07) | SCR §1.5 p.4; ARQ Anexo A p.58 | HU25 | 4 | Documentado; vínculo propuesto |
| RF06 | Recibir posiciones de serenos operativos con autorización GPS (alias [HU]: RF08) | SCR §1.5 p.4; ARQ Anexo A p.58 | HU18 | 2 | Documentado; vínculo propuesto |
| RF07 | Estado y última posición; disponible = operativo sin asignación vigente (alias [HU]: RF09) | SCR §1.5 p.4; ARQ Anexo A p.58 | HU19; parte de HU18/HU24 | 2 | Documentado; vínculo propuesto |
| RF08 | Mostrar teléfono y registrar intentos, resultados y referencias de contacto (alias [HU]: RF10) | SCR §1.5 p.4; ARQ Anexo A p.58 | HU12 | 2 | Documentado; vínculo propuesto |
| RF09 | Asignar caso pendiente a sereno disponible por operador (alias [HU]: RF11) | SCR §1.5 p.4; ARQ Anexo A p.58 | HU20 (A/B propuestos) | 2–3 | Documentado; vínculo propuesto |
| RF10.1 | Notificar despacho y consultar datos y ubicación del caso (alias [HU]: RF12) | SCR §1.5 p.4; ARQ Anexo A p.58 | HU21 | 2 | Documentado; vínculo propuesto |
| RF10.2 | Sereno asignado confirma desplazamiento (alias [HU]: RF13) | SCR §1.5 p.4; ARQ Anexo A p.58 | HU22 | 2 | Documentado; vínculo propuesto |
| RF11.1 | Inicio de atención por sereno asignado u operador (alias [HU]: RF14) | SCR §1.5 p.4; ARQ Anexo A p.58 | HU23 | 2 | Documentado; vínculo propuesto |
| RF11.2 | Cierre con tipificación y resultado por sereno asignado u operador (alias [HU]: RF15) | SCR §1.5 p.4; ARQ Anexo A p.58 | HU24 | 2 | Documentado; vínculo propuesto |
| RF12.1 | Historial de SOS/reportes con estados, asignaciones y actuaciones (alias [HU]: RF16 (parcial)) | SCR §1.5 p.4; ARQ Anexo A p.58 | HU27 | 3; cierre 5 | Documentado; vínculo propuesto |
| RF12.2 | Filtros combinables: fechas, origen, tipo, estado y sereno (alias [HU]: RF19) | SCR §1.5 p.5; ARQ Anexo A p.58 | HU26 | 3 | Documentado; vínculo propuesto |
| RF13 | Separar tiempos de respuesta SOS y revisión/atención de reportes (alias [HU]: RF17) | SCR §1.5 p.5; ARQ Anexo A p.58 | HU28 | 5 | Documentado; vínculo propuesto |
| RF14 | Mapa de calor por periodo/origen; excluir cancelados y descartados (alias [HU]: RF18) | SCR §1.5 p.5; ARQ Anexo A p.58 | HU29 | 5 | Documentado; vínculo propuesto |
| RF15 | Administrador crea, consulta, modifica y desactiva cuentas institucionales (alias [HU]: RF20) | SCR §1.5 p.5; ARQ Anexo A p.58 | HU04; HU05 | 1; 4 | Documentado; vínculo propuesto |
| RF16.1 | Reporte separado del SOS: tipo, descripción, ubicación, fecha/hora aproximadas (alias [HU]: RF23) | SCR §1.5 p.5; ARQ Anexo A p.58 | HU10 | 3 | Documentado; vínculo propuesto |
| RF16.2 | Categorías: violencia doméstica, robo, presunta actividad de drogas y Otros (alias [HU]: RF24) | SCR §1.5 p.5; ARQ Anexo A p.58 | HU10; HU13; HU14 | 2–3 | Documentado; vínculo propuesto |
| RF17 | Revisar reporte: admisión, derivación o descarte justificado (alias [HU]: RF25) | SCR §1.5 p.5; ARQ Anexo A p.58 | HU14–HU17 | 3; HU17 cierre 5 | Documentado; vínculo propuesto |
| RF18.1 | Ciudadano consulta casos propios, estado y avances públicos (alias [HU]: RF26) | SCR §1.5 p.5; ARQ Anexo A p.58 | HU30 | 3 | Documentado; vínculo propuesto |
| RF18.2 | Notificaciones dentro de la app al cambiar estado público propio (alias [HU]: RF27) | SCR §1.5 p.5; ARQ Anexo A p.58 | HU31 | 3 | Documentado; vínculo propuesto |
| RF19 | Evaluación voluntaria de caso cerrado: 1–5 y comentario opcional (alias [HU]: RF28) | SCR §1.5 p.5; ARQ Anexo A p.58 | HU32; HU33 | 5 | Documentado; vínculo propuesto |
| RF20.1 | Acompañamiento voluntario hasta 30 min con aceptación de finalidad (alias [HU]: RF29) | SCR §1.5 p.5; ARQ Anexo A p.58 | HU34 | 4 | Documentado; vínculo propuesto |
| RF20.2 | Finalizar voluntariamente o a 30 min; sin renovación automática (alias [HU]: RF31) | SCR §1.5 p.5; ARQ Anexo A p.58 | HU36; HU37 | 4 | Documentado; vínculo propuesto |
| RF21 | Posiciones durante sesión activa; operador autorizado ve hora y precisión (alias [HU]: RF30) | SCR §1.5 p.5; ARQ Anexo A p.58 | HU35; HU38 | 4 | Documentado; vínculo propuesto |
| RF22 | Confirmación de bienestar: Estoy bien / Necesito ayuda (alias [HU]: RF32) | SCR §1.5 p.5; ARQ Anexo A p.59 | HU40; HU41 | 5 | Documentado; vínculo propuesto |
| RF23.1 | Reglas configuradas generan avisos técnicos separados de SOS (alias [HU]: RF33) | SCR §1.5 p.5; ARQ Anexo A p.59 | HU42 | 5 | Documentado; vínculo propuesto |
| RF23.2 | Revisar avisos, registrar acciones y vincular caso cuando corresponda (alias [HU]: RF34) | SCR §1.5 p.6; ARQ Anexo A p.59 | HU43 | 5 | Documentado; vínculo propuesto |

## Requisitos no funcionales

| ID | Descripción resumida | Fuente | HU relacionada | Sprint previsto | Estado |
|---|---|---|---|---|---|
| RNF01 | Hash específico de contraseñas con configuración documentada; sin texto plano ni cifrado reversible | SCR §1.5 p.6 | HU01/HU04 (SCR §3.2, S1-T06/T11, pp.17) | 1; revisión posterior | Documentado; pendiente de validación |
| RNF02 | 20 sesiones; ≥95% de ≥100 SOS presentados y notificados en ≤3 s desde aceptación del servidor; no es respuesta del sereno | SCR §1.5 p.6 | HU11 (SCR S1-T18, p.18) | 1; repetición propuesta en 2 | Documentado; pendiente de validación |
| RNF03 | 20 sesiones durante 30 min; ≥5 acompañamientos; sin pérdidas confirmadas ni asignaciones inconsistentes | SCR §1.5 p.6 | No hay correspondencia HU única documentada | Validación global (ARQ §11.3, p.52) | Documentado; pendiente de validación |
| RNF04 | Flujos móviles a 360/390/412 píxeles CSS; sin superposición ni desplazamiento horizontal | SCR §1.5 p.6 | Flujos de SOS, reporte, acompañamiento, consulta y despacho; sin IDs en la tabla RNF | Validación global (ARQ §11.3, p.52) | Documentado; pendiente de validación |
| RNF05 | Panel en Chrome y Firefox estables fijados; 1366×768 y 1920×1080; operaciones completas | SCR §1.5 p.6 | No hay correspondencia HU única documentada | Validación global (ARQ §11.3, p.52) | Documentado; pendiente de validación |
| RNF06 | SOS con una activación autenticada, sin formularios ni confirmación adicional; éxito solo tras servidor, con/sin GPS | SCR §1.5 p.6 | HU07/HU08 (ARQ §5.1, p.20) | 1 (SCR S1-T13/T16, p.18) | Documentado; pendiente de validación |
| RNF07 | GPS ciudadano solo para SOS, reporte por elección o sesión activa; abrir app no transmite; permiso no activa sesión | SCR §1.5 p.7 | HU06/HU07/HU08 (SCR S1-T12/T16, pp.17–18); HU10/HU34–HU37 (ARQ §5, pp.23–26) | 1, 3, 4 según flujos | Documentado; pendiente de validación |
| RNF08 | Consistencia bajo concurrencia/repetición: una asignación vigente por caso, una sesión activa por ciudadano, sin parciales ni duplicados | SCR §1.5 p.7 | HU09/HU14–HU17/HU20/HU22–HU24/HU32/HU34/HU41 (ARQ §1.6, p.6) | Transversal; sin sprint único documentado | Documentado; pendiente de validación |
| RNF09 | HTTPS y equivalente seguro persistente en validación publicada; sin credenciales/reportes/coordenadas por canal abierto | SCR §1.5 p.7 | HU02 (SCR S1-T08, p.17) | 1; transversal | Documentado; pendiente de validación |
| RNF10 | ≥99% disponibilidad durante 8 h controladas; medir interrupciones de acceso, registro y panel; sin garantía municipal | SCR §1.5 p.7 | No hay correspondencia HU única documentada | Validación global (ARQ §11.3, p.52) | Documentado; pendiente de validación |
| RNF11 | Estado, tiempo restante y problemas persistentes; posición antigua visible; validar inicialmente app visible con conexión | SCR §1.5 p.7 | HU34–HU38 (ARQ §5.4/5.5, pp.24–26) | 4 | Documentado; pendiente de validación |
| RNF12 | Confidencialidad por rol/titularidad; ciudadano solo casos/avances propios; notas y recorridos restringidos; probar solicitudes directas | SCR §1.5 p.7 | HU03 (ARQ §11.5, p.54) | 1–5 acumulativo | Documentado; pendiente de validación |
| RNF13 | Eliminar recorridos según plazo definido; excepciones con finalidad/registro; no aprobar sin plazo y reglas definitivos | SCR §1.5 p.7 | HU39-B (ARQ §9.9, p.45; SCR §3.2, S4-T14, p.27) | 4 condicionado a DP22 | Documentado; aceptación bloqueada DP22 |
| RNF14 | Código estructurado y versionado en ramas; revisión del repositorio GitHub | SCR §1.5 p.7 | No hay correspondencia HU única documentada | No documentado | Documentado; pendiente de validación |

## Historias de usuario

I = implementación; P = precondición; A = aceptación; R = riesgo/capacidad compartida, siguiendo las etiquetas de SCR. Las dependencias siguientes se transcriben de la planificación, incluidas sus propuestas. HU20-A/B y HU39-A/B no son historias originales nuevas. TEC01 (entorno) y SPIKE01 (viabilidad GPS) son habilitadores, no HU.

| ID | Descripción resumida | Fuente | HU relacionada | Sprint previsto | Estado |
|---|---|---|---|---|---|
| HU01 | Registrar mi cuenta de ciudadano — Ciudadano | SCR §3.1 p.10 | — | 1 | Must; planificada, no implementada |
| HU02 | Iniciar sesión — Ciudadano y otros roles | SCR §3.1 p.10 | I: HU01; P: cuenta existente (HU04 o DP02) | 1 | Must; planificada, no implementada |
| HU03 | Acceder solo a funciones y datos de mi rol — Todos | SCR §3.1 p.10 | I: HU02; A: HU04–HU43 (CA04) | 1–5 (cierre diferido) | Must; planificada, no implementada |
| HU04 | Crear, consultar y modificar cuentas institucionales — Administrador | SCR §3.1 p.10 | I: HU02/HU03; P: administrador (DP02) | 1 | Must; planificada, no implementada |
| HU05 | Desactivar cuenta institucional — Administrador | SCR §3.1 p.13 | I: HU04; A: HU27 (CA03) | 4 | Must; planificada, no implementada |
| HU06 | Preparar geolocalización al abrir la aplicación — Ciudadano | SCR §3.1 p.10 | Sin dependencia funcional; R: SPIKE01 | 1 | Must; planificada, no implementada |
| HU07 | Emitir SOS con una única activación — Ciudadano | SCR §3.1 p.10 | I: HU03; P: HU01/HU02; R: HU08 (aceptación conjunta) | 1 | Must; planificada, no implementada |
| HU08 | Asociar ubicación actual al SOS — Ciudadano | SCR §3.1 p.10 | I: HU07/HU06 | 1 | Must; planificada, no implementada |
| HU09 | Cancelar SOS pendiente — Ciudadano | SCR §3.1 p.13 | I: HU07; A: HU11-CA02/HU20-A-CA06/HU34-CA07 (citas a confirmar) | 5 | Should; planificada, no implementada |
| HU10 | Registrar reporte de incidencia — Ciudadano | SCR §3.1 p.11 | I: HU03; P: autenticado; R: catálogo HU13 | 3 | Must; planificada, no implementada |
| HU11 | Recibir SOS en sección de atención urgente — Operador | SCR §3.1 p.10 | I: HU07/HU03; P: cuenta HU04 | 1 | Must; planificada, no implementada |
| HU12 | Contactar ciudadano y registrar verificación del SOS — Operador | SCR §3.1 p.11 | I: HU07/HU03; A: HU20-A (CA06) | 2 | Must; planificada, no implementada |
| HU13 | Clasificar SOS después de su registro — Operador | SCR §3.1 p.11 | I: HU07/HU03; R: catálogo DP07 | 2 | Must; planificada, no implementada |
| HU14 | Iniciar revisión de reporte y corregir categoría — Operador | SCR §3.1 p.11 | I: HU10/HU26 (corrección propuesta) | 3 | Must; planificada, no implementada |
| HU15 | Admitir reporte para atención — Operador | SCR §3.1 p.11 | I: HU14; A: HU20-B (CA02) | 3 | Must; planificada, no implementada |
| HU16 | Derivar reporte — Operador | SCR §3.1 p.12 | I: HU14; A: HU27 (CA04) | 3 | Must; planificada, no implementada |
| HU17 | Descartar reporte con justificación — Operador | SCR §3.1 p.12 | I: HU14; A: HU27 (CA03)/HU29 (CA04, Could) | 3; cierre 5 | Must; planificada, no implementada |
| HU18 | Activar estado operativo y compartir ubicación — Sereno | SCR §3.1 p.11 | I: HU02/HU03; P: HU04; R: SPIKE01 | 2 | Must; planificada, no implementada |
| HU19 | Monitorear estado y disponibilidad de serenos — Operador | SCR §3.1 p.11 | I: HU18; R: HU20-A/HU24 | 2 | Must; planificada, no implementada |
| HU20 | Asignar caso pendiente a sereno disponible — Operador | SCR §3.1 p.11–12 | A: I HU07/HU19/HU03, A HU12-CA06; B: I HU20-A/HU15; división propuesta | 2 (A); 3 (B) | Must; planificada, no implementada |
| HU21 | Recibir y consultar despacho — Sereno | SCR §3.1 p.11 | I: HU20-A | 2 | Must; planificada, no implementada |
| HU22 | Confirmar desplazamiento al caso — Sereno | SCR §3.1 p.11 | I: HU21 | 2 | Must; planificada, no implementada |
| HU23 | Registrar inicio de atención — Sereno y operador | SCR §3.1 p.11 | I: HU22 | 2 | Must; planificada, no implementada |
| HU24 | Cerrar caso con tipificación y resultado — Sereno y operador | SCR §3.1 p.11 | I: HU23; R: HU13 (catálogo)/HU19 (CA07 citado en SCR) | 2 | Must; planificada, no implementada |
| HU25 | Visualizar casos en mapa — Operador | SCR §3.1 p.12 | I: HU07/HU08/HU10 | 4 | Must; planificada, no implementada |
| HU26 | Buscar y filtrar casos — Operador | SCR §3.1 p.11 | I: HU07/HU10; listado base para HU14 | 3 | Must; planificada, no implementada |
| HU27 | Consultar historial de caso — Operador | SCR §3.1 p.12 | I: HU07/HU10; A: actuaciones HU12–HU17/HU20/HU22–HU24; HU09 para Cancelada | 3; cierre 5 | Must; planificada, no implementada |
| HU28 | Consultar tiempos de respuesta y atención — Operador | SCR §3.1 p.13 | I: HU23/HU14; marcas HU07/HU10 | 5 | Should; planificada, no implementada |
| HU29 | Consultar mapa de concentración de incidencias — Operador | SCR §3.1 p.14 | I: HU07/HU10; R: exclusión HU17 | 5 | Could; planificada, no implementada |
| HU30 | Consultar mis casos — Ciudadano | SCR §3.1 p.12 | I: HU07/HU10; R: resultado público HU24 | 3 | Must; planificada, no implementada |
| HU31 | Recibir notificaciones de avances de mis casos — Ciudadano | SCR §3.1 p.12 | I: HU07/HU10; R: eventos HU15–HU17/HU20–HU24 | 3 | Must; planificada, no implementada |
| HU32 | Evaluar atención de caso cerrado — Ciudadano | SCR §3.1 p.13 | I: HU24/HU30 | 5 | Could; planificada, no implementada |
| HU33 | Consultar evaluaciones de atención — Operador | SCR §3.1 p.14 | I: HU32 | 5 | Could; planificada, no implementada |
| HU34 | Activar acompañamiento temporal — Ciudadano | SCR §3.1 p.12 | I: HU06/HU03; P: autenticado; R: SPIKE01 | 4 | Must; planificada, no implementada |
| HU35 | Compartir posición durante acompañamiento — Ciudadano | SCR §3.1 p.12 | I: HU34; R: SPIKE01/HU18 | 4 | Must; planificada, no implementada |
| HU36 | Finalizar acompañamiento cuando decida — Ciudadano | SCR §3.1 p.12 | I: HU34 | 4 | Must; planificada, no implementada |
| HU37 | Cierre automático del acompañamiento a 30 minutos — Ciudadano; sistema ejecuta vencimiento | SCR §3.1 p.12 | I: HU34; R: HU36 | 4 | Must; planificada, no implementada |
| HU38 | Consultar acompañamientos activos y posiciones — Operador | SCR §3.1 p.13 | I: HU35/HU03 | 4 | Must; planificada, no implementada |
| HU39 | Consultar historial de sesiones de acompañamiento — Operador | SCR §3.1 p.13 | A: I HU34, A HU36/HU37; B: I HU39-A y bloqueo DP22; división propuesta | 4 (A/B); B condicionado | Must; planificada, no implementada |
| HU40 | Solicitar confirmación de bienestar — Operador | SCR §3.1 p.13 | I: HU34/HU03 | 5 | Should; planificada, no implementada |
| HU41 | Responder confirmación de bienestar — Ciudadano | SCR §3.1 p.13 | I: HU40/HU07; R: HU08 | 5 | Should; planificada, no implementada |
| HU42 | Recibir avisos técnicos y de verificación — Operador | SCR §3.1 p.13 | I: HU35; A: HU41 (CA02) | 5 | Should; planificada, no implementada |
| HU43 | Revisar avisos y registrar atención — Operador | SCR §3.1 p.13 | I: HU42; R: HU20; CA05 pendiente DP19 (SCR S5-T09, p.29) | 5 | Should; planificada, no implementada |

HU39 no tiene equivalente explícito en SCR §1.5: ARQ Anexo A p.59 lo registra como RF16 parcial de [HU]. No se asigna artificialmente a RF12.1 ni RF21. CA completos y algunas DP no están definidos en los adjuntos; véanse [análisis](analisis-requisitos.md) y [decisiones pendientes](../architecture/decisiones-pendientes.md).
