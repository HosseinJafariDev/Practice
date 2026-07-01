namespace Application.UseCase.Products.CreateProduct;

public interface ICreateProductUseCase
{
    Task ExecuteAsync(CreateProductInputDto  input);
}