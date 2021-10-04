# WatchShop
A sample ASP.NET Project with Clean Architecture based on https://github.com/dotnet-architecture/eShopOnWeb.

## Packages Installed
### Web

### Infrastructure
Install-Package Microsoft.EntityFrameworkCore

Install-Package Npgsql.EntityFrameworkCore.PostgreSQL

Install-Package Ardalis.Specification.EntityFrameworkCore

Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore

### ApplicationCore
Install-Package Ardalis.Specification

## EF Commands
**Default project: src\Infrastructure**

Add-Migration InitialIdentity -Context AppIdentityDbContext -OutputDir "Identity/Migrations"

Update-Database -Context AppIdentityDbContext

Add-Migration InitialApp -Context ApplicationDbContext -OutputDir "Data/Migrations"

Update-Database -Context ApplicationDbContext 

### Links
https://mdbootstrap.com/docs/b4/jquery/ecommerce/design-blocks/shopping-cart/

