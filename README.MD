## Entity Framework Commands (PowerShell)
<br />

To open the terminal within Visual Studio: ``CRTL + ` `` 
<br />
![Open PoweShell Visual Studio](assets/images/open-power-shell-visual-studio.png)
***

Install: ``dotnet tool install --global dotnet-ef``
<br />
![dotnet ef Install](assets/images/dotenet-ef-install.png)
***

Uninstall: ``dotnet tool uninstall --global dotnet-ef``
<br />
![dotnet ef Uninstall](assets/images/dotenet-ef-Uninstall.png)
***

See installation details: ``dotnet ef``
<br />
![dotnet ef Version](assets/images/dotenet-ef-version.png)
***

Create Migrations: ``dotnet ef migrations add MyFirstMigrations``
<br />
***

Create SQL Script by Migrations: ``dotnet ef migrations script -o MyFirstMigrations.sql``
<br />
Use the parameter ``-i`` to generate the idempotent SQL Script
<br />
***

Execute Migration on database: ``dotnet ef database update -v``
<br />
***

Rollback / revert Migrations: ``dotnet ef database update MinhaTargetMigrationRollBackName``
<br />
***

Remove last migrations: ``dotnet ef migrations remove``
<br />
***

## Entity Framework Commands (NPM - Package Manager Console command)
<br />

To open the console in Visual Studio, go to the main menu and select ``Tools > NuGet Package Manager > Package Manager Console command.``
<br />
![Open NPM(Package Manager Console command) Visual Studio](assets/images/open-NPM-visual-studio.png)
***

View the Entity Framework migration command list: ``get-help entityframework``
<br />
![Entity Framework migration command list](assets/images/Entity-Framework-migration-command-list.png)
***

## C# quick tips
Execute Migrations by code: 
```
using Microsoft.EntityFrameworkCore;
...
using var context = new ApplicationContext();
context.Database.Migrate();
// or
// await context.Database.MigrateAsync();
```
***

Get Pending Migrations:
```
using Microsoft.EntityFrameworkCore;
...
using var context = new ApplicationContext();
context.Database.GetPendingMigrations();
// or
// await context.Database.GetPendingMigrationsAsync();
```
***