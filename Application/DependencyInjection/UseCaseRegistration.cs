using Application.UseCase.Auth;
using Application.UseCase.Auth.login;
using Application.UseCase.Auth.register;
using Application.UseCase.Products.CreateProduct;
using Application.UseCase.Products.DeleteProduct;
using Application.UseCase.Products.GetProduct;
using Application.UseCase.Products.UpdateProduct;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependencyInjection;

public static class UseCaseRegistration
{
    public static IServiceCollection AddUseCase(this IServiceCollection services)
    {
        services.AddScoped<ILoginUseCase, LoginUseCase>();
        services.AddScoped<IRegisterUseCase, RegisterUseCase>();
        services.AddScoped<ICreateProductUseCase, CreateProductUseCase>();
        services.AddScoped<IDeleteProductUseCase, DeleteProductUseCase>();
        services.AddScoped<IGetProductUseCase, GetProductUseCase>();
        services.AddScoped<IUpdateProductUseCase, UpdateProductUseCase>();
        services.AddScoped<IValidGuidUseCase, ValidGuidUseCase>();

        return services;
    }
}