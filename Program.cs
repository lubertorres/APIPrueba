
using apiPrueba.Domain.Services;
using apiPrueba.Interface;
using apiPrueba.Models;
using Microsoft.EntityFrameworkCore;

IConfiguration config = new ConfigurationBuilder()
      .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
      .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true, reloadOnChange: true)
      .AddEnvironmentVariables()
      .Build();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PruebaContext>(options =>
    options.UseSqlServer(config.GetConnectionString("cn")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUsuario, UsuarioR>();
builder.Services.AddScoped<IProducto, ProductoP>();
builder.Services.AddScoped<IUsuarioProducto, UsuarioProductoR>();
builder.Services.AddScoped<IEstadoProducto, EstadoProductoP>();
builder.Services.AddScoped<IRoles, RolesR>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
