using prueba.Models;
using Microsoft.EntityFrameworkCore;
using prueba.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))); // Usamos PostgreSQL

builder.Services.AddControllers();

// Agregar servicios de autenticación (JWT)
builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer(options =>
    {
        options.Authority = builder.Configuration["JwtSettings:Issuer"];
        options.Audience = builder.Configuration["JwtSettings:Audience"];
        options.RequireHttpsMetadata = false;
    });

var app = builder.Build();

// Crear productos iniciales si no existen
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

    if (!context.Productos.Any())
    {
        context.Productos.AddRange(
            new Producto { Nombre = "Producto 1", Cantidad = 100 },
            new Producto { Nombre = "Producto 2", Cantidad = 50 },
            new Producto { Nombre = "Producto 3", Cantidad = 200 }
        );
        context.SaveChanges();
    }
}

// Configurar el pipeline de la aplicación
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

