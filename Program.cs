using Ocelot.DependencyInjection;
using Ocelot.Middleware;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// aggiungo Ocelot
builder.Services.AddOcelot();


app.MapGet("/", () => "Hello World!");

// Ocelot
app.UseOcelot();
app.Run();
