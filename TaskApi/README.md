# EasyTask Backend (ASP.NET Core Web API)

This is the backend API for the EasyTask application, built with ASP.NET Core and Entity Framework Core.

## Setup Steps

1. **Install .NET SDK 8.0 or later.**
   - Download from: https://dotnet.microsoft.com/download

2. **Restore dependencies:**
   ```sh
   dotnet restore
   ```

3. **Apply database migrations:**
   ```sh
   dotnet ef database update
   ```
   (Make sure your connection string in `appsettings.json` is correct.)

   - To add a new migration:
     ```sh
     dotnet ef migrations add <MigrationName>
     ```
   - Migration files are stored in the `Migrations/` folder.

4. **Run the API:**
   ```sh
   dotnet run
   ```
   The API will be available at `http://localhost:5000` (or as configured).

## Accessing the API Documentation (Swagger UI)

- **Swagger UI** is enabled by default in development mode.
- After running the API, open your browser and go to:
  - [http://localhost:5000/swagger](http://localhost:5000/swagger)
- Here, you can view all available API endpoints, see request/response schemas, and interactively test the API.
- If you change the port or host, adjust the URL accordingly.

## Explanation Notes

- This API provides endpoints for managing tasks (CRUD operations).
- Uses Entity Framework Core with MySQL (via Pomelo) for data storage.
- Includes robust error handling via custom middleware.
- Follows a clean architecture with controllers, services, models, and data layers.
- Database schema changes are managed via Entity Framework Core migrations.

## File Structure

```
TaskApi/
├── Controllers/
│   └── TasksController.cs      # API endpoints for task operations
├── Services/
│   ├── TaskService.cs         # Business logic for tasks
│   └── ITaskService.cs        # Service interface for dependency injection
├── Data/
│   └── TaskDbContext.cs       # Entity Framework Core database context
├── Models/
│   └── TaskItem.cs            # Task entity model
├── Middleware/
│   └── ErrorHandlingMiddleware.cs # Global error handling middleware
├── Migrations/
│   ├── 20250723134121_InitialCreate.cs           # Initial migration (schema definition)
│   ├── 20250723134121_InitialCreate.Designer.cs  # Designer file for the initial migration
│   └── TaskDbContextModelSnapshot.cs             # Snapshot of the current database model
├── Program.cs                 # Main entry point and app configuration
├── appsettings.json           # Main configuration (connection strings, etc.)
├── appsettings.Development.json # Development-specific settings
├── TaskApi.csproj             # Project file and dependencies
└── ...                        # Build, migration, and property files
```

## Component Overview

- **TasksController.cs**: Defines HTTP endpoints for getting, creating, updating, and deleting tasks.
- **TaskService.cs**: Implements business logic for task management.
- **ITaskService.cs**: Interface for the task service, used for dependency injection.
- **TaskDbContext.cs**: Configures the database context and entity sets for EF Core.
- **TaskItem.cs**: Represents a task entity in the database.
- **ErrorHandlingMiddleware.cs**: Catches and logs unhandled exceptions, returning a consistent error response.
- **Migrations/**: Contains Entity Framework Core migration files:
  - **20250723134121_InitialCreate.cs**: The initial migration that creates the database schema.
  - **20250723134121_InitialCreate.Designer.cs**: Designer file for the initial migration.
  - **TaskDbContextModelSnapshot.cs**: Snapshot of the current model, used by EF Core to determine changes.
- **Program.cs**: Configures services, middleware, and app startup.

## Notes
- Ensure your MySQL server is running and the connection string in `appsettings.json` is correct before running migrations or the API.
- The API is designed to work with the EasyTask frontend, but can be used independently.
- You can add more controllers, services, or models as your application grows.
- Use `dotnet ef migrations add <MigrationName>` to create new migrations when your model changes.

---

For more information on ASP.NET Core, see the [official documentation](https://docs.microsoft.com/aspnet/core/introduction-to-aspnet-core). 