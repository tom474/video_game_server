# Video Game Server

Video Game Server is an ASP.NET Core backend that provides a structured Web API project with controllers, models, Entity Framework Core, and SQL Server configuration.

## Tech Stack

- Server: ASP.NET Core (.NET 8), Entity Framework Core
- Database: Microsoft SQL Server (e.g., SQLExpress)
- Tooling: .NET SDK 8.0+, Visual Studio 2022+ or VS Code

## Features

- Web API project with Controllers and Models
- Entity Framework Core with SQL Server integration
- Existing EF Core migrations
- Configuration via `appsettings.json` and `appsettings.Development.json`
- OpenAPI documentation enabled in Development via Scalar.AspNetCore
- HTTPS redirection and authorization middleware

## Quick Start

> Follow these steps to set up the project locally on your machine.

Clone the repository

```bash
git clone https://github.com/tom474/video_game_server.git
```

Navigate to the project directory

```bash
cd video_game_server
```

Configure the database connection

- Update the SQL Server connection string in:
  - `VideoGameServer/appsettings.Development.json` (for local development), or
  - `VideoGameServer/appsettings.json`

Example:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost\\SQLExpress;Database=VideoGameDb;Trusted_Connection=true;TrustServerCertificate=true;"
  }
}
```

Restore dependencies and build

```bash
dotnet restore
dotnet build
```

Apply database migrations

```bash
# If you don't have it yet:
# dotnet tool install --global dotnet-ef

dotnet ef database update --project ./VideoGameServer
```

Run the server

```bash
# CLI
dotnet run --project ./VideoGameServer

# Or open VideoGameServer.sln in Visual Studio and press F5
```
