## the following is the command to scaffold the database entities and context in their correspoding directories

``` powershell
dotnet ef dbcontext scaffold "Name=ConnectionStrings:DefaultConnection" Microsoft.EntityFrameworkCore.SqlServer --context-dir ../WebApp.Infrastructure/Data --output-dir ../WebApp.Domain/Entities --force
```