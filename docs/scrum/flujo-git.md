# Flujo de ramas y responsabilidades

Regla de trabajo aprobada por el responsable, vinculada a RNF14 (SCR §1.5 p.7); los nombres de ramas y la división de responsabilidades no son requisitos textuales del PDF.

- `main`: estado estable. Recibe la promoción de `develop` mediante PR aprobado.
- `develop`: integración. Es la base de nuevas `feature/*`.
- `feature/*`: una unidad de trabajo revisable; PR hacia `develop`, con validaciones y revisión antes de integrar.
- No realizar merges automáticos, reescribir historial ni publicar sin autorización. Conservar archivos/commits existentes; evitar incluir secretos o cambios ajenos.

Codex implementa y valida; solo consulta Git para inspección. Claude Code gestiona exclusivamente las operaciones Git/GitHub de escritura/publicación según autorización del responsable. La Etapa 2.1C deja cambios sin commit para auditoría; no autoriza staging, commit, push, PR ni merge.

La feature actual ya existía antes de esta corrección. No se reorganiza el historial ni se mueve ninguna rama para aplicar este flujo.

Calendario: SCR §4.5/§5 pp.37–39 propone cinco sprints del 07/09 al 26/10/2026, validación 27–28/10 y entrega objetivo 29/10. ARQ D13 p.8 registra desfase. El PO/equipo deben revisar capacidad, fechas y orden; aquí no se aprueba un calendario nuevo.
