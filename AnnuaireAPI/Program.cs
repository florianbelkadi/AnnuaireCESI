using AnnuaireAPI.Middleware;
using AnnuaireModel.Context;
using AnnuaireModel.Dao;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NLog.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

//configuration de l'authentification
builder.Services.AddAuthentication(IdentityConstants.ApplicationScheme)
    .AddIdentityCookies();
builder.Services.AddAuthorizationBuilder();

builder.Services.AddIdentityCore<User>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<AnnuaireContext>()
    .AddApiEndpoints();

//chaine de connexion
string connexionString = builder.Configuration.GetConnectionString("MainConnexionString") ??
    throw (new Exception("Connection string is missing"));

builder.Services.AddDbContext<AnnuaireContext>(options => options
        .UseMySql(connexionString, ServerVersion.AutoDetect(connexionString)));

// Add services to the container.
builder.Services.AddScoped<AnnuaireContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuration nLog
builder.Logging.ClearProviders();
builder.Logging.AddNLog("NLog.config");

var app = builder.Build();

// Configure l'entité Identity
app.MapIdentityApi<User>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<LoggingMiddleware>();

app.Run();
