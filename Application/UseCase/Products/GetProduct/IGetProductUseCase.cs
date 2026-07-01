namespace Application.UseCase.Products.GetProduct;

public interface IGetProductUseCase
{
    Task<List<GetProductOutputDto>> ExecuteAsync();
}