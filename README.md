# School App - Angular & .NET

Aplicación web desarrollada como prueba técnica para la gestión académica básica de una institución educativa.

El sistema permite administrar **Estudiantes**, **Profesores** y **Notas**, incluyendo operaciones CRUD y la asociación entre profesores y estudiantes a través de las notas.

---

## Tecnologías utilizadas

### Backend
- ASP.NET Core 8
- Entity Framework Core
- SQL Server
- Swagger (OpenAPI)
- Migrations (Code First)

### Frontend
- Angular (Standalone Components)
- TypeScript
- Bootstrap
- HTML / CSS

---

## Estructura del proyecto
##  Instalación y ejecución

###  Requisitos previos
- .NET SDK 8
- Node.js (v18 o superior)
- Angular CLI
- SQL Server
- Visual Studio o VS Code

---

###  Backend (.NET)

1. Abrir la carpeta del backend:
backend/School.Api


2. Configurar la cadena de conexión en el archivo:
appsettings.json


3. Ejecutar las migraciones de Entity Framework:
```bash
dotnet ef database update

4. Ejecutar el proyecto:
dotnet run

5.Abrir Swagger en el navegador:
https://localhost:7277/swagger


### Frontend (Angular)

1. Abrir la carpeta del frontend:
frontend/school-app

2. Instalar dependencias:
npm install

3.Ejecutar la aplicación:
ng serve --o --port 4200

4. Acceder desde el navegador:
http://localhost:4200





