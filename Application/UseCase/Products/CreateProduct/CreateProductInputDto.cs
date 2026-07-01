namespace Application.UseCase.Products.CreateProduct;

public class CreateProductInputDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
}