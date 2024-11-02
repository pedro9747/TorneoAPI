using Microsoft.EntityFrameworkCore;
using TorneoApi.Models;
using TorneoBack.Repository;
using TorneoBack.Repository.Contracts;
using TorneoBack.Service;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
builder.Services.AddControllers();
// Configuraci�n de Swagger para desarrollo.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuraci�n de la base de datos.
builder.Services.AddDbContext<TorneoContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configuraci�n de repositorios y servicios.
builder.Services.AddScoped<IJugadorRepository, JugadorRepository>();
builder.Services.AddScoped<ITorneoRepository, TorneoRepository>();
builder.Services.AddScoped<IEquiposRepository, EquiposRepository>();
builder.Services.AddScoped<ITorneoService, TorneoService>();


// Configuraci�n de CORS para permitir todos los or�genes, m�todos y encabezados.
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTodo", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configuraci�n del pipeline HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Aplicar la pol�tica CORS que permite cualquier origen.
app.UseCors("PermitirTodo");

app.UseAuthorization();

app.MapControllers();

app.Run();
