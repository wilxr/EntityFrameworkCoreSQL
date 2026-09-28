# Lectura de datos con Entity Framework Core

Aplicación de consola desarrollada en C# que muestra cómo consultar una base de datos de cursos utilizando Entity Framework Core y SQL Server.

El programa obtiene los cursos registrados junto con sus instructores mediante carga anticipada con `Include` y `ThenInclude`.

## Tecnologías utilizadas

- .NET Core 3.1
- C#
- Entity Framework Core 3.1.2
- SQL Server

## Modelo de datos

El proyecto incluye las siguientes entidades:

- `Curso`: información general del curso.
- `Instructor`: datos de los instructores.
- `CursoInstructor`: relación muchos a muchos entre cursos e instructores.
- `Precio`: precio actual y promocional de cada curso.
- `Comentario`: comentarios y puntuaciones de los alumnos.

## Requisitos

Para ejecutar el proyecto necesitas:

- .NET Core SDK 3.1.201
- SQL Server
- SQL Server Management Studio u otra herramienta compatible
- Una instancia local de SQL Server con autenticación integrada de Windows

> .NET Core 3.1 está fuera de soporte. Este proyecto utiliza esa versión con fines educativos o de compatibilidad.

## Configuración de la base de datos

1. Abre el archivo `LeerData/scriptDB.sql` en SQL Server Management Studio.
2. Revisa y adapta las rutas físicas de los archivos `.mdf` y `.ldf` si no coinciden con tu instalación.
3. Ejecuta el script para crear la base de datos `CursosOnline`.
4. Verifica la cadena de conexión definida en `LeerData/AppVentaCursosContext.cs`:

```csharp
Data Source=localhost;
Initial Catalog=CursosOnline;
Integrated Security=True;
TrustServerCertificate=True;