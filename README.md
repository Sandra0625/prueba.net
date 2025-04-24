Proyecto Prueba.net
Este proyecto es una aplicación backend desarrollada con .NET Core 9 y PostgreSQL. Utiliza autenticación basada en JWT y permite realizar operaciones CRUD sobre una tabla de productos.

1. Descripción del Proyecto
El sistema permite la gestión de productos con funcionalidades de autenticación mediante JWT (JSON Web Tokens). El backend está desarrollado con .NET Core 9 y usa PostgreSQL como sistema de base de datos. La aplicación también está configurada para utilizar un servicio de autenticación para proteger los endpoints de la API.

2. Prerrequisitos
Antes de comenzar, asegúrate de tener lo siguiente instalado en tu máquina:

Software necesario:
.NET 9 SDK: Asegúrate de tener instalado .NET 9.0 para poder ejecutar el proyecto.

PostgreSQL: Este proyecto usa PostgreSQL como base de datos.

Visual Studio 2022 o superior: Idealmente con soporte para proyectos .NET Core.

Git: Para clonar el repositorio y manejar el código fuente.

Cuentas necesarias:
Cuenta en GitHub: Para clonar y gestionar el repositorio.

Cuenta en PostgreSQL: Para configurar y administrar la base de datos.

3. Instalación
Paso 1: Clonar el repositorio
Para clonar este repositorio, usa el siguiente comando:

bash
Copiar
Editar
git clone https://github.com/Sandra0625/prueba.net.git
Paso 2: Restaurar las dependencias
Una vez que el proyecto esté clonado, abre la carpeta del proyecto en Visual Studio o en tu editor favorito. Luego, ejecuta el siguiente comando para restaurar las dependencias del proyecto:

bash
Copiar
Editar
dotnet restore
Paso 3: Configurar la base de datos
Debes crear una base de datos en PostgreSQL. En tu archivo appsettings.json, configura la cadena de conexión con los detalles de tu base de datos. Por ejemplo:

json
Copiar
Editar
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Username=postgres;Password=tu-contraseña;Database=prueba_db"
  }
}
Paso 4: Ejecutar las migraciones
Una vez que la base de datos esté configurada, ejecuta las migraciones para crear las tablas necesarias:

bash
Copiar
Editar
dotnet ef database update
4. Configuración
En el archivo appsettings.json, asegúrate de configurar los siguientes parámetros de JWT:

json
Copiar
Editar
{
  "JwtSettings": {
    "Issuer": "https://tu-issuer.com",
    "Audience": "https://tu-audience.com",
    "SecretKey": "TuClaveSecreta"
  }
}
Issuer: La URL que emite el token JWT.

Audience: La URL que recibe y valida el token JWT.

SecretKey: La clave secreta que se usa para firmar el JWT.

5. Ejecución del Proyecto
Para ejecutar el proyecto localmente, usa el siguiente comando:

bash
Copiar
Editar
dotnet run
La aplicación debería estar disponible en http://localhost:5000.

6. Endpoints de la API
A continuación, se muestran algunos de los principales endpoints de la API:

POST /api/auth/login: Inicia sesión y recibe un token JWT.

GET /api/productos: Obtiene la lista de productos.

POST /api/productos: Crea un nuevo producto.

PUT /api/productos/{id}: Actualiza un producto existente.

DELETE /api/productos/{id}: Elimina un producto.

7. Pruebas
Para probar la API, puedes utilizar herramientas como Postman o cURL. Asegúrate de enviar el token JWT en los encabezados de las solicitudes de autenticación.

Ejemplo de autenticación:
bash
Copiar
Editar
POST http://localhost:5000/api/auth/login
Body: {
  "email": "user@example.com",
  "password": "password"
}
Recibirás un token JWT que podrás usar en los encabezados de las siguientes solicitudes.

8. Contribuciones
Si deseas contribuir al proyecto, sigue estos pasos:

Haz un fork del repositorio.

Crea una rama (git checkout -b nueva-funcionalidad).

Realiza tus cambios y haz commit (git commit -am 'Agrega nueva funcionalidad').

Haz push a la rama (git push origin nueva-funcionalidad).

Abre un pull request con una descripción clara de los cambios.

9. Licencia
Este proyecto está bajo la licencia MIT.
