Cadena de conexión (Consola de paquetes nutGet):

Scaffold-DbContext 'Server=localhost,2526;Initial Catalog=ExampleDB;Persist Security Info=False;User ID=sa;Password=root1992*;MultipleActiveResultSets=False;Encrypt=false;TrustServerCertificate=False;Connection Timeout=30;' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models/ -f -NoPluralize



Dependencias: EntityFrameworkCore
EntityFrameworkCore.SqlServer
EntityFrameworkCore.Tools




Inyeccion de dependencias en el Program.cs:
// Add services to the container.
builder.Services.AddDbContext<PruebaContext>(options =>
    options.UseSqlServer(config.GetConnectionString("cn")));


IConfiguration config = new ConfigurationBuilder()
      .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
      .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true, reloadOnChange: true)
      .AddEnvironmentVariables()
      .Build();



Cadena de conexión en el archivo appsettings.Development:
"ConnectionStrings": {
    "cn": "Server=localhost,2526;Initial Catalog=prueba;Persist Security Info=False;User ID=sa;Password=root1992*;MultipleActiveResultSets=False;Encrypt=false;TrustServerCertificate=False;Connection Timeout=30;"
  },



Comando para levantar servicio sql contenedor docker (Ejecutar en poswershell):
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=root1234*" -p 1434:1433 -d mcr.microsoft.com/mssql/server:2022-latest