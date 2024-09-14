using PorBaixoDosPanos;
using Serilog;

// Configuração Builder
var builder = WebApplication.CreateBuilder(args);

// Configuração do Pipeline

builder.AddSerilog();

builder.Services.AddControllersWithViews();

// Configuração da App
var app = builder.Build();

app.UseLogTempo();

app.MapGet("/", () => "Hello World!");

app.MapGet("/teste", () =>
{
    Thread.Sleep(1500);
    return "Teste 2";
});

app.Run();
