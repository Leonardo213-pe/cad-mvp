# Reglas compartidas del repositorio

## Alcance y fuentes
- Proyecto: Sistema Integrado de Monitoreo, Alertas Georreferenciadas y Despacho CAT (Sistema CAD).
- Consultar los PDF originales de `docs/requirements/`, su análisis y matriz antes de implementar; citar requisito/HU, sección y página. No inventar requisitos ni modificar los originales.
- El análisis actual es incompleto y no acredita aprobación. Marcar información no verificable; separar requisitos, inferencias y propuestas técnicas.
- Esta etapa solo crea estructura y archivos base. No implementar HU, generar proyectos .NET/React, instalar dependencias o PostgreSQL local, ni hacer commit/push automático.
- En etapas posteriores, respetar el alcance autorizado por el usuario y revisar las decisiones pendientes antes de adoptar tecnologías.

## Arquitectura propuesta
- `apps/{ciudadano,sereno,central}`: espacios para interfaces futuras; sus nombres no definen permisos ni funcionalidades.
- `backend/src/CAD.Domain`: dominio independiente de frameworks y persistencia.
- `CAD.Application` depende de `CAD.Domain`; define casos de uso y contratos.
- `CAD.Infrastructure` implementa contratos de Application y puede depender de Domain.
- `CAD.Api` expone el transporte y compone dependencias; no contiene reglas de negocio. Su composición puede referenciar Infrastructure.
- Evitar dependencias de Domain/Application hacia Api o Infrastructure y dependencias circulares. Esta dirección es una propuesta técnica pendiente de validación, no un requisito extraído de los PDF.
- Reservar `tests/CAD.UnitTests` y `tests/CAD.IntegrationTests`; definir herramientas y estrategia al aprobar los proyectos.

## Seguridad
- No versionar credenciales, tokens, certificados privados, archivos de entorno reales ni datos personales. Usar `.env.example` únicamente con valores ficticios o vacíos.
- No incluir secretos ni datos personales en registros, pruebas o documentación. Revisar cambios antes de compartirlos.
- Al implementar, validar entradas y aplicar autenticación/autorización en el servidor según permisos documentados; no asumir que el nombre de una app concede acceso.

## Convenciones
- Usar `.editorconfig`; conservar convenciones y archivos existentes. Documentación concisa en español, sin duplicar fuentes.
- Ubicar decisiones técnicas y su estado en `docs/decisions/`; enlazar análisis existentes en lugar de copiarlos.
- Preservar los identificadores originales de requisitos e historias. Distinguir dependencias explícitas de las inferidas.
- Hacer cambios mínimos y verificables; ejecutar comprobaciones adecuadas sin instalar herramientas salvo autorización.
- No agregar versiones, bibliotecas, infraestructura ejecutable ni comandos de arranque hasta elegir y crear los proyectos.
