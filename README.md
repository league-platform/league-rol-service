# rol-service

Este proyecto es un servicio de gestión de roles, que permite realizar operaciones CRUD sobre roles en una base de datos.

## Estructura del Proyecto

- **Controllers/RoleController.cs**: Contiene la clase `RoleController`, que maneja las solicitudes relacionadas con los roles. Exporta métodos como `GetRoles`, `GetRoleById`, `CreateRole`, `UpdateRole` y `DeleteRole`.

- **Models/Role.cs**: Define la clase `Role`, que representa el modelo de datos para un rol. Exporta propiedades como `Id`, `Name` y `Description`.

- **Data/AppDbContext.cs**: Contiene la clase `AppDbContext`, que hereda de `DbContext`. Se encarga de la configuración de la base de datos y define las propiedades `DbSet<Role>` para acceder a los roles en la base de datos.

- **Program.cs**: Punto de entrada de la aplicación. Configura y ejecuta el servidor web, así como la inyección de dependencias y la configuración de middleware.

- **appsettings.json**: Contiene la configuración de la aplicación, como la cadena de conexión a la base de datos y otras configuraciones específicas del entorno.

- **Dockerfile**: Define la imagen de Docker para la aplicación. Especifica cómo construir la imagen, incluyendo la instalación de dependencias y la configuración del entorno de ejecución.

- **.dockerignore**: Lista los archivos y carpetas que deben ser ignorados al construir la imagen de Docker.

## Instrucciones de Configuración

1. Clona el repositorio en tu máquina local.
2. Asegúrate de tener instalado .NET y Docker.
3. Configura la cadena de conexión en `appsettings.json`.
4. Ejecuta el proyecto usando el comando `dotnet run` o construye la imagen de Docker usando el `Dockerfile`.

## Contribuciones

Las contribuciones son bienvenidas. Si deseas contribuir, por favor abre un issue o envía un pull request.