using Mango.GatewaySolution.Extensions;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;


var builder = WebApplication.CreateBuilder(args);
// USO L'autenticazione che ho dentro la cartella extension
builder.AddAppAuthentication();
// aggiungo Ocelot
builder.Services.AddOcelot();
var app = builder.Build();



app.MapGet("/", () => "Hello World!");

// Ocelot
app.UseOcelot();
app.Run();
