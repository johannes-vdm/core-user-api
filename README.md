- Authorization

  - AllowAnonymousAttribute.cs
  - AuthorizeAttribute.cs
  - JwtMiddleware.cs
  - JwtUtils.cs

- Controllers

    - UsersController.cs

- Entities

  - User.cs
  - Helpers
  - AppException.cs
  - AppSettings.cs
  - AutoMapperProfile.cs
  - DataContext.cs
  - ErrorHandlerMiddleware.cs
  - MysqlDataContext.cs

- Migrations

  - MySQLMigrations

    - 20210521001551_InitialCreate.cs

    - 20210521001551_InitialCreate.Designer.cs

     - MysqlDataContextModelSnapshot.cs

  - SqlServerMigrations

    - 20210521001453_InitialCreate.cs
    - 20210521001453_InitialCreate.Designer.cs
    - DataContextModelSnapshot.cs

- Models

- Users
  - AuthenticateRequest.cs
  - AuthenticateResponse.cs
  - RegisterRequest.cs
  - UpdateRequest.cs

- Services

  - UserService.cs
  - appsettings.Development.json
  - appsettings.json
  - omnisharp.json
  - Program.cs
  - Startup.cs
  - WebApi.csproj