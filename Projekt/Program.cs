using Microsoft.EntityFrameworkCore;
using Projekt.Components;
using Projekt.Data;
using Projekt.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var dbFileName = connectionString!.Replace("Data Source=", "");
var dbPath = System.IO.Path.Combine(builder.Environment.ContentRootPath, dbFileName);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite($"Data Source={dbPath}"));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseStaticFiles(); 
app.UseAntiforgery();


app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();