using ProductApi.Endpoints;
using ProductApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen; // ensure this namespace is present if the IDE needs it

var builder = WebApplication.CreateBuilder(args);

// Add services for Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger in development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/", () => "Welcome to the Minimal API! Visit /swagger for API documentation.");

/// <summary>
/// Maps product-related endpoints.
/// </summary>
app.MapPost("/products", (Product product) =>
{
    return ProductEndpoint.CreateProduct(product);
});

app.MapGet("/products", () =>
{
    return ProductEndpoint.GetAllProducts();
});

app.MapGet("/products/{id:int}", (int id) =>
{
    return ProductEndpoint.GetProductById(id);
});

app.MapDelete("/products/{id:int}", (int id) =>
{
    return ProductEndpoint.DeleteProduct(id);
});

app.Run();