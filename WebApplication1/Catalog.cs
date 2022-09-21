namespace WebApplication1;

public class Catalog
{
    public List<Product> Products { get; set; } = new()
    {
        new Product(1, "Чистый код", 100),
        new Product(2, "Чистая архитектура", 200),
        new Product(3, "Entity Framewrok в действии", 300),
    };
}