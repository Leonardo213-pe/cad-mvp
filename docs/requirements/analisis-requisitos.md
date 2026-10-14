# Análisis de requisitos del Sistema CAD

Estado: fuentes PDF leídas; documentación preparada para auditoría, no aceptación de historias. La decisión tecnológica del responsable está aceptada en [ADR-002](../architecture/decisions/0002-arquitectura-definitiva.md). No cambia los RF/RNF originales.

## Fuentes y alcance de evidencia

**SCR**: [Plan Scrum actualizado](Plan_Scrum_Sistema_Integrado_CAD_-_actualizado.pdf), 39 páginas. **ARQ**: [Plan de Arquitectura](Plan_de_Arquitectura_Sistema_Integrado_CAD.pdf), 68 páginas, versión 1.0 propuesta (control de versiones p.2). Referencias por página física del PDF, contando portada. Texto extraído con Poppler 25.07.0, UTF-8 y separadores de página; los PDF permanecen intactos. El texto de los diagramas se complementa con sus fuentes en ARQ Anexo B pp.60–65; no se considera texto de un diagrama una obligación técnica independiente.

ARQ §0.1–0.2 p.4 cita una fuente [HU] de historias estructuradas y respuestas del equipo [EQ] que **no están adjuntas**. Se puede verificar lo reproducido en los PDF, pero no el contenido íntegro ni la aprobación de esos originales. No se inventan CA ni se presume resuelta una DP.

## RF, RNF e historias

La [matriz de trazabilidad](matriz-trazabilidad.md) es el catálogo único: **34 RF operativos bajo 23 grupos RF01–RF23**, **14 RNF (RNF01–RNF14)** y **43 HU (HU01–HU43)**, con descripciones, páginas, relaciones y sprints tentativos. Evita duplicar aquí sus tablas.

- Cuentas y permisos: RF01.1/RF01.2, RF02, RF15; HU01–HU05. Registro ciudadano y administración de cuentas institucionales son funciones distintas (SCR §1.5 pp.3,5).
- SOS y geolocalización: RF03.1–RF03.3, RF04, RF05.1, RF08; HU06–HU09, HU11–HU13. No confundir SOS con reporte ni acompañamiento (SCR §1.5 pp.3–4).
- Despacho/atención: RF06–RF07, RF09, RF10.1–RF10.2, RF11.1–RF11.2; HU18–HU24 (SCR §1.5 p.4).
- Reportes y consultas: RF05.2, RF12.1–RF12.2, RF13–RF14, RF16.1–RF16.2, RF17, RF18.1–RF18.2, RF19; HU10, HU14–HU17, HU25–HU33 (SCR §1.5 pp.4–5).
- Acompañamiento/bienestar: RF20.1–RF20.2, RF21–RF23.2; HU34–HU43. HU39 figura en el backlog sin equivalente explícito en el catálogo RF de SCR (ARQ Anexo A p.59).

RNF01/09/12 cubren credenciales, cifrado y confidencialidad; RNF07/11/13 privacidad, transparencia y retención; RNF08 integridad; RNF04/05/06 interfaces y usabilidad; RNF14 mantenibilidad (SCR §1.5 pp.6–7). No sustituir estos requisitos por decisiones de framework.

Umbrales verificables: RNF02 exige ≥95% de ≥100 SOS en ≤3 s desde aceptación del servidor con 20 sesiones; RNF03 exige 20 sesiones durante 30 min, ≥5 acompañamientos y ausencia de operaciones confirmadas perdidas/asignaciones inconsistentes; RNF10 exige ≥99% durante 8 h controladas. RNF04 conserva 360/390/412 **píxeles CSS**; RNF05 conserva Chrome y Firefox con versiones fijadas y resoluciones 1366×768/1920×1080. Son criterios documentados, no objetivos de producción ni tiempo de llegada del sereno (SCR §1.5 pp.6–7).

## Actores y límites de permisos

| Actor | Operaciones y límite documentado | Evidencia |
|---|---|---|
| Ciudadano | Registro/sesión; emitir SOS y reportes; cancelar solo SOS propio pendiente; consultar avances propios; evaluar caso cerrado; activar/cerrar acompañamiento y responder bienestar. Sin notas internas ni datos de terceros | SCR §1.5 pp.3–7; ARQ §1.3 p.5, §9.5 pp.43–44 |
| Sereno | Activar estado operativo y compartir GPS autorizado; consultar despacho asignado; confirmar desplazamiento; iniciar/cerrar atención según asignación | SCR §1.5 p.4; ARQ §1.3 p.5, §3.6 p.13 |
| Operador | Recibir/verificar/clasificar/revisar/asignar y registrar atención; consultar mapas, historial, tiempos, evaluaciones y acompañamientos según autorización | SCR §1.5 pp.4–6; ARQ §1.3 p.5; DP04 en §1.9 p.8 |
| Administrador | Crear/consultar/modificar/desactivar operadores y serenos. Alta inicial y tratamiento de sesiones/asignaciones al desactivar pendientes; no inferir acceso universal a casos/recorridos | RF15, SCR p.5; HU04/HU05, SCR §3.1 pp.10,13; ARQ §1.9 p.8 |
| Sistema | Vencimiento y avisos por reglas; no es un rol humano autenticado. Eliminación condicionada a retención definida | RF20.2/RF23.1, SCR p.5; ARQ §1.3 p.5, §9.9 p.45 |

Municipalidad, equipo, docente/jurado y proveedor de mapas son stakeholders, no permisos adicionales de aplicación (SCR §1.6 p.8). La matriz definitiva de operaciones por rol debe resolver DP04 y comprobar solicitudes directas y titularidad; ocultar controles no basta (HU03, RNF12).

## Reglas y criterios reproducidos verificables

Estos son resúmenes de RF/RNF o CA **citados en los PDF**, no una reconstrucción completa del documento [HU].

| Regla / criterio | Identificador y referencia |
|---|---|
| Un control SOS sin formulario; confirmar solo tras respuesta del servidor; reenvío técnico sin duplicados. Capturar posición actual; si falta, registrar SOS, sin reutilizar ubicación antigua | RNF06/08, SCR p.6–7; HU07-CA03/CA07 y HU08-CA02/CA03, ARQ §5.1 p.21 |
| Contactar y clasificar un SOS no bloquean la asignación; solo casos pendientes y serenos disponibles. Una asignación vigente por caso y por sereno; cerrar libera disponibilidad | RF07/RF09, SCR p.4; HU12-CA06/HU13-CA02, HU20-CA04/CA05, HU24-CA07, ARQ §5.2 p.22 |
| SOS inicia Pendiente; reporte Recibido → En revisión → Pendiente al admitir, o Derivada/Descartada. Ciclo común: Asignada → En camino → En atención → Cerrada. Cancelada solo para SOS propio pendiente | HU09-CA01/CA03, ARQ §5.8 p.29; RF03.3/RF17, SCR pp.4–5 |
| Ubicación del reporte elegida por el ciudadano; no confundir listado de reportes con sección urgente; conservar categoría original al corregir | HU10-CA04, HU14-CA05, ARQ §5.3 pp.23–24; RNF07, SCR p.7 |
| Acompañamiento voluntario con finalidad aceptada y una sola sesión activa; posición/permiso necesarios para iniciarlo; intento de transmisión cada 15 s con sesión activa | HU34-CA02/CA03/CA06 y HU35-CA01, ARQ §1.5 p.6, §5.4 p.25; SCR §3.3 p.32 |
| Finalizar detiene captura/envío inmediatamente incluso sin conexión; servidor vence a 30 min; rechazar puntos tardíos; sin renovación ni peligro automático ni cancelación de SOS | HU36-CA01/CA03/CA04/CA05/CA06, HU37-CA01/CA03/CA04/CA05, ARQ §5.5 p.26, §5.8 p.30 |
| Bienestar solo en sesión activa; solicitud no crea SOS ni despacho; Necesito ayuda inicia o vincula SOS sin duplicarlo. Estados que cuentan como SOS vigente pendientes | HU40-CA02/CA03, HU41-CA03/CA04, ARQ §5.6 p.27 y D9 p.7 |
| Avisos: más de 60 s sin puntos o 2 min sin respuesta a solicitud presentada; uno por condición persistente en sesión activa; separados de SOS y sin despacho automático | HU42-CA01/CA02/CA03/CA04/CA06, HU43-CA06, ARQ §5.7 p.28, §9.9 p.45 |
| Evaluación 1–5, una por caso cerrado; historial de actuaciones separado de recorridos; retención sin plazo definitivo no aceptable | RF19, SCR p.5; S5-T11, SCR p.29; HU27-CA05/HU39-CA01, ARQ §9.1 p.42; RNF13, SCR p.7 |

Las frecuencias internas de temporizador, índices SQL, DTO, endpoints, reintentos y algoritmo concreto de hash propuestos por ARQ son soluciones técnicas; no nuevos RF/RNF. La retención excepcional requiere finalidad y registro (RNF13); no se fija un plazo ficticio.

## Dependencias y desarrollo incremental

El detalle por HU está en la matriz (SCR §3.1 pp.10–14). Se distinguen implementación, precondición, aceptación y riesgo/capacidad compartida: una dependencia de aceptación no exige implementar una historia completa antes que otra.

| Sprint tentativo | Incremento y dependencia principal | Evidencia |
|---|---|---|
| 1 | TEC01/SPIKE01; HU01/HU02/HU03/HU04/HU06/HU07/HU08/HU11. HU07+HU08 se aceptan juntas; HU03 queda abierta. Administrador inicial depende DP02 | SCR §3.2 pp.16–18; §3.3 p.31 |
| 2 | HU12/HU13/HU18/HU19/HU20-A/HU21–HU24; cadena operativa → disponibilidad → asignación → desplazamiento → atención → cierre | SCR §3.2 pp.19–21; §3.3 p.32 |
| 3 | HU10/HU26/HU14–HU17/HU20-B/HU27/HU30/HU31. HU14 usa listado HU26. HU17 y HU27 conservan cláusulas abiertas hasta Sprint 5 | SCR §3.1 pp.11–12; §3.3 p.32 |
| 4 | HU05/HU25/HU34–HU39 (A/B propuestos). HU39-B bloqueada DP22; sin cierre/privacidad/retención solo demostración controlada | SCR §3.2 pp.25–27; §3.3 p.32 |
| 5 | HU09/HU28/HU29/HU32/HU33/HU40–HU43; comprobar CA04 de HU03, CA02 de HU27, CA04 de HU17 y caso urgente HU43-CA05 | SCR §3.2 pp.28–30; §3.3 p.33 |

No declarar aceptación solo por implementación. SCR §3.3 p.31 distingue implementada/integrada/aceptada/liberada. HU20 y HU39 originales se dividen A/B como **propuesta**, no decisión de alcance; conservar sus IDs. El calendario 07/09–26/10/2026, validación 27–28/10 y entrega objetivo 29/10 necesita revisión por capacidad/desfase (SCR §4.5/§5 pp.37–39; ARQ D13 p.8). No se inventan fechas ni SP completados.

## Restricciones, contradicciones y límites del MVP

- MVP académico de municipalidad tipo B con usuarios y coordenadas simulados. Sin canal real de emergencias ni integración PNP/Bomberos/SAMU/RENIEC, despacho IA ni compromiso de recursos estatales (SCR §1.4 p.3).
- PWA en primer plano para GPS y despacho; sin garantía en segundo plano o app cerrada. HTTPS y cloud gratuito/educativo; disponibilidad de demostración no es servicio 24/7 (SCR §1.5 pp.7–8).
- ARQ proponía MAUI 10, Razor Pages y ASP.NET Core 10 (pp.3,12,16; ADR originales pp.49–50). La aprobación actual establece React/PWA y API .NET 8: **decisión de implementación que sustituye esas propuestas**, no modificación de RF/RNF. No convertir RNF04 de CSS a dp ni eliminar Firefox de RNF05.
- Numeraciones RF distintas y equivalencias propuestas (ARQ D1 p.7, Anexo A pp.58–59); falta cobertura RF explícita de HU39 (D14 p.8). No tratarlas como correspondencias confirmadas.
- Mapa HU25 previsto en Sprint 4 frente a criterios de HU11/HU19 anteriores (ARQ D3 p.7). ARQ propone componente temprano; requiere ratificación de planificación.
- “Ruta exacta”, “más cercano” y “gestión de llamadas” no acreditan ruteo, selección automática o telefonía integrada (ARQ D4–D6 p.7; SCR §2.1 p.9). Confirmar interpretación del PO sin ampliar alcance.
- Suspensión de servicios gratuitos frente a RNF02/RNF10 (ARQ D7 p.7, §8.3 p.40). Proveedor backend/frontend, modo de validación y costos siguen pendientes; Neon aprobado no acredita latencia ni disponibilidad.
- SCR §1.5 documenta RNF03/04/05/10, pero §3.2/§3.3 pp.16,31 dice que no puede evaluarlos sin contenido: inconsistencia interna. Usar los criterios explícitos del catálogo, sin borrar los originales.

## Compatibilidad arquitectónica y validación pendiente

El monolito modular aprobado es coherente con 20 sesiones, equipo de tres personas y entrega incremental (ARQ §10.1 p.48). Tres interfaces React preservan dos PWA y panel de SCR §1.4 p.2. EF Core/Npgsql y SignalR son decisiones técnicas para persistencia/tiempo real; sus mecanismos aún deben probar RNF02/03/08/09/10 y restricciones del navegador. La compatibilidad es conceptual, **no validación de rendimiento, privacidad ni aceptación del MVP**.

No se pueden cerrar los CA completos sin la fuente [HU]. Las DP originales y decisiones propias están diferenciadas en [decisiones pendientes](../architecture/decisiones-pendientes.md); las aprobaciones y dependencias internas, en ADR-002. Reservadas pruebas de carga en `tests/CAD.LoadTests/` para RNF02/03, sin implementar un arnés.
