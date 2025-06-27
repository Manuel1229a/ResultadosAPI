# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiamos solo el proyecto
COPY . .

# Restauramos paquetes desde la carpeta actual
RUN dotnet restore "./ResultadosAPI.csproj"

# Publicamos la app
RUN dotnet publish "./ResultadosAPI.csproj" -c Release -o /app/publish

# Etapa de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 80
ENTRYPOINT ["dotnet", "ResultadosAPI.dll"]
