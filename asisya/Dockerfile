# -------- STAGE 1: Build --------
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copiar archivos de solución
COPY *.sln .

# Copiar proyectos
COPY ProviderOptimizer.API/*.csproj ProviderOptimizer.API/
COPY ProviderOptimizer.Application/*.csproj ProviderOptimizer.Application/
COPY ProviderOptimizer.Domain/*.csproj ProviderOptimizer.Domain/
COPY ProviderOptimizer.Infrastructure/*.csproj ProviderOptimizer.Infrastructure/

# Restaurar dependencias
RUN dotnet restore

# Copiar todo el código
COPY . .

# Publicar aplicación
WORKDIR /src/ProviderOptimizer.API
RUN dotnet publish -c Release -o /app/publish


# -------- STAGE 2: Runtime --------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

COPY --from=build /app/publish .

# Exponer puerto
EXPOSE 8080

# Configurar entorno
ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Production

ENTRYPOINT ["dotnet", "ProviderOptimizer.API.dll"]