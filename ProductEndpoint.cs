using ProductApi.Models;

namespace ProductApi.Endpoints;

public static class ProductEndpoint
{
    // Simple in-memory list to store products.
    // This is fine for learning, but real apps usually use a database.
    private static readonly List<Product> Products = new();
    private static int _nextId = 1;

    /// <summary>
    /// Creates a new product and adds it to the in-memory list.
    /// </summary>
    public static IResult CreateProduct(Product product)
    {
        product.ProductId = _nextId++;
        Products.Add(product);

        return Results.Created($"/products/{product.ProductId}", product);
    }

    /// <summary>
    /// Returns all products.
    /// </summary>
    public static IResult GetAllProducts()
    {
        return Results.Ok(Products);
    }

    /// <summary>
    /// Returns a single product by ID.
    /// </summary>
    public static IResult GetProductById(int id)
    {
        var product = Products.FirstOrDefault(p => p.ProductId == id);

        return product is null
            ? Results.NotFound(new { message = $"Product with ID {id} not found." })
            : Results.Ok(product);
    }

    /// <summary>
    /// Deletes a product by ID.
    /// </summary>
    public static IResult DeleteProduct(int id)
    {
        var product = Products.FirstOrDefault(p => p.ProductId == id);

        if (product is null)
        {
            return Results.NotFound(new { message = $"Product with ID {id} not found." });
        }

        Products.Remove(product);
        return Results.Ok(new { message = $"Product with ID {id} deleted successfully." });
    }
}
