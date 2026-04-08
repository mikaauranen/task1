var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Terveisiä .NET 10:stä! Tämä on lisätty ilman terminaalia.");

app.Run();
