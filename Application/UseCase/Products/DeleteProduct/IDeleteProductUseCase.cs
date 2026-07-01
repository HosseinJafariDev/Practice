using Application.UseCase.Products.CreateProduct;

namespace Application.UseCase.Products.DeleteProduct;

public interface IDeleteProductUseCase
{
    Task ExecuteAsync(int id);
}