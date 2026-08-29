# evaluacion20262

Portal de Solicitudes de Servicio Técnico - TecnoGas Hogar

Aplicación web MVC con .NET 10, Entity Framework Core + SQLite.

## Requisitos

- .NET 10 SDK
- Docker (para despliegue en Render)

## Ejecutar localmente

```bash
dotnet run
```

## Configuración

La cadena de conexión SQLite se encuentra en `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Data Source=tecnogas.db"
}
```

## Despliegue en Render

La aplicación incluye un `Dockerfile` para despliegue en Render como Web Service.

### Variables de entorno en Render
- `PORT`: Asignada automáticamente por Render
