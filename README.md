# Provider Optimizer Service

Microservicio desarrollado en .NET 10 para la selección óptima de
proveedores dentro del sistema de asistencias vehiculares.

------------------------------------------------------------------------

## Estructura del Proyecto

ProviderOptimizerService.sln

-   ProviderOptimizer.API
-   ProviderOptimizer.Application
-   ProviderOptimizer.Domain
-   ProviderOptimizer.Infrastructure
-   ProviderOptimizer.Tests

------------------------------------------------------------------------

## Tecnologías

-   .NET 10
-   ASP.NET Core Web API
-   Entity Framework Core
-   SQL Server
-   Docker
-   xUnit

------------------------------------------------------------------------

## Cómo ejecutar con Docker

### Requisitos

-   Docker Desktop instalado

### Ejecutar

Desde la raíz del proyecto:

docker-compose up --build

### Acceder a la API

http://localhost:5000/swagger

------------------------------------------------------------------------

## Base de Datos

Se utiliza SQL Server en contenedor Docker.

Configuración por defecto:

Server: localhost\
Database: ProvidersDb\
User: sa\
Password: Your_password123!

La cadena de conexión se configura mediante variables de entorno.

------------------------------------------------------------------------

## Endpoint Principal

### POST /api/providers/assign

Selecciona el proveedor óptimo disponible.

### Request

{ "clientLatitude": 4.60, "clientLongitude": -74.08 }

------------------------------------------------------------------------

## Ejecutar pruebas

dotnet test

------------------------------------------------------------------------

## CI/CD

Pipeline configurado en GitHub Actions que ejecuta:

-   Restore
-   Build
-   Tests
-   Docker build
