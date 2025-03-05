namespace Catalog.API.Products.CreateProduct;

public record class CreateProductRequest(string Name, List<string> Category, string Description, string ImgaeFile, decimal Price);
public record CreateProductResponse(Guid Id);
public class CreateProductEndpoint
{
}
