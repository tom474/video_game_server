# Video Game Server

Video Game Server is a C#/.NET server foundation intended for multiplayer gameplay (real-time or turn-based). It provides a starting point for networking, session management, and future game-specific logic.

## Tech Stack

- Server: C# (.NET), Visual Studio solution (`VideoGameServer.sln`)
- Build Tools: .NET SDK 8.0+ or Visual Studio 2022+
- Package Management: NuGet

## Features

- Core server project scaffold in C#
- Structured solution layout for easy development and deployment
- Extensible architecture for:
  - Session and player management (planned)
  - Matchmaking/lobbies (planned)
  - Persistence/data store integration (planned)
  - Health/readiness endpoints and basic observability (planned)

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

Restore dependencies and build

```bash
dotnet restore
dotnet build
```

Run the server (CLI)

```bash
# Option A: Run by project directory
dotnet run --project ./VideoGameServer

# Option B: If you prefer, open the solution in Visual Studio and press F5
```

Environment configuration

- No required environment variables at this time.
- If the project introduces configuration files later, place them in `VideoGameServer/appsettings.json` and `appsettings.Development.json` as needed.
