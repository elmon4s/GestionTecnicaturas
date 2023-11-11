- Proyecto del Grupo 11
- Tema: Gestion de Tecnicaturas de la UTN FRC
- Integrantes:
- Gallo, Mateo (404947)
- Masera, Gustavo Martin (405153)
- Monasterio, Mateo (404888)
- Paredes, Esteban (405226)
- Romero Beskow, Joaquin (405632)
- Implementaciones del Proyecto:
1. ABMC Docentes
2. Transaccion de Examen con Detalle Examen
     Se implementa utilizando SPs que filtran Docente segun la materia y Alumnos segun la condicion de la materia
3. Transaccion de Alumno con Detalle Alumno (Inscripcion a Examenes)
     Se implementa utilizando SPs que filtran las materias a las que el Alumno no se inscribio o esta libre
- Ademas el proyecto cuenta con el uso de patrones de diseño:
     Facade, DAO y Singleton
- Para Gestionar los usuarios utilizamos el paquete NuGet [BCrypt .Net Core] para el hasheo y verificacion de los Usuarios
- Para Reportes utilizamos Telerik Reporting Tool y Telerik UI for WinForms
