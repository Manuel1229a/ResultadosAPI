# Etapa 1: build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiamos todo el proyecto
COPY . .

# RUTA DEL PROYECTO
WORKDIR /src/ResultadoAPI

# Restauramos paquetes
RUN dotnet restore

# Compilamos para producción
RUN dotnet publish -c Release -o /app/publish

# Etapa 2: runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Railway usa el puerto 80
EXPOSE 80
ENTRYPOINT ["dotnet", "ResultadoAPI.dll"]
