using Projekt.Components;
using Tailwind;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    // Usuwamy 'await', aby Tailwind nie blokował startu serwera
    // Metoda RunTailwind powinna uruchomić proces w tle
    app.RunTailwind("dev"); 
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // To musi być przed Antiforgery i Mapowaniem!
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();