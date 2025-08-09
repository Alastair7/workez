using Microsoft.EntityFrameworkCore;
using Workez.Infrastructure.Persistence;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;


var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
//  Configure Entity Framework Core with PostgreSQL
var connectionString = configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PostgresContext>(options =>
    options.UseNpgsql(connectionString));
// Register repositories
builder.Services.AddScoped<Workez.Domain.Interfaces.IShiftRepository, Workez.Infrastructure.Repositories.ShiftRepository>();
// Register application services
builder.Services.AddScoped<Workez.Application.Services.ShiftService>();
// Configure CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});

// Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Workez API",
        Version = "v1"
    });
});

// Authentication config
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = configuration["Jwt:Issuer"],
        ValidAudience = configuration["Jwt:Audience"]
    };
});

builder.Services.AddAuthorization();
builder.Services.AddControllers();
builder.Services.AddScoped<Workez.Application.Services.ShiftService>();

// Construye la app después de configurar los servicios
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapGet("/healthCheck", async (PostgresContext db) =>
{
    try
    {
        await db.Database.CanConnectAsync();
        return Results.Ok("Database connection is healthy.");
    }
    catch (Exception ex)
    {
        return Results.Problem($"Database connection failed: {ex.Message}");
    }
});
app.MapControllers();
app.Run();