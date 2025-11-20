# UsersWeb

Aplicación ASP.NET Core (Razor Pages) que muestra una lista de usuarios aleatorios en la página principal.

## Requisitos
- .NET 8 SDK

## Ejecución local
```bash
dotnet restore UsersWeb.sln
dotnet run --project UsersWeb/UsersWeb.csproj
```
Abre `https://localhost:5001` (o el puerto mostrado) y añade `?count=20` para cambiar la cantidad de usuarios.

## Estructura
- `UsersWeb/Models/User.cs`: Modelo de usuario.
- `UsersWeb/Services/RandomUserService.cs`: Servicio para generar usuarios.
- `UsersWeb/Pages/Index.*`: Página que muestra la lista.
- `UsersWeb.Tests/`: Pruebas unitarias.
- `.github/workflows/ci-cd.yml`: Workflow GitHub Actions.

## Pruebas
```bash
dotnet test UsersWeb.Tests/UsersWeb.Tests.csproj
```

## CI/CD
El workflow ejecuta build, tests y publica el proyecto. Luego despliega a Azure Web App.

### Secretos necesarios en el repositorio
Configura en GitHub (Settings > Secrets and variables > Actions):
- `AZURE_CLIENT_ID`
- `AZURE_TENANT_ID`
- `AZURE_SUBSCRIPTION_ID`
- `AZURE_CLIENT_SECRET`
- `AZURE_WEBAPP_NAME`

### Despliegue
Al hacer push en `main` el job `deploy` publica el contenido a la Web App indicada.

## Futuras mejoras
- Paginación y filtros.
- Persistencia en base de datos.
- Endpoint API para JSON.
