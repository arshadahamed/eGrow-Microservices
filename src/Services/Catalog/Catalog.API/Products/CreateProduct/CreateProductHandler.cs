﻿namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand(string Name, List<string> Category, string Description, string ImgaeFile, decimal Price)
    :ICommand<CreateProductResult>;
public record CreateProductResult(Guid Id);
internal class CreateProductCommandHandler(IDocumentSession session)
    : ICommandHander<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        //Business logic to create a product
        var product = new Product
        {
            Name = command.Name,
            Category = command.Category,
            Description = command.Description,
            ImgaeFile = command.ImgaeFile,
            Price = command.Price
        };
        //save to database
        session.Store(product);
        await session.SaveChangesAsync(cancellationToken);

        //return the result

        return new CreateProductResult(product.Id);

    }
}
