using Microsoft.AspNetCore.Builder;
using Fibonacci;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello world!");
app.MapGet("/Fibonacci", async () => await Compute.ExecuteAsync(new[] {"44", "43"}));

app.Run();
