namespace Application.UseCase.Products.UpdateProduct;

public interface IUpdateProductUseCase
{
    Task ExecuteAsync(UpdateProductInputDto input);
}