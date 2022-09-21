using Microsoft.AspNetCore.Http.Json;
using WebApplication1;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<JsonOptions>(
    options =>
    {
        options.SerializerOptions.WriteIndented = true;
    });

var app = builder.Build();
var catalog = new Catalog();

app.MapGet("/", () => "Hello World!");
app.MapGet("/catalog", () =>
{
    return catalog.Products;
});

app.MapPost("/catalog/add_product", 
    (Product product, HttpContext context) =>
{
    catalog.Products.Add(product);
    context.Response.StatusCode = 201;
});


app.Run();