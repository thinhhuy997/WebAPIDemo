using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. 
builder.Services.AddControllers(); // n?i ?? ??ng k� (register) c�c dependencies v�o our WEB API FRAMEWORK

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.MapControllers(); 
// MapController will map the HTTP requests to our controllers like "ShirtsController" in ShirtsController.cs

app.Run();
