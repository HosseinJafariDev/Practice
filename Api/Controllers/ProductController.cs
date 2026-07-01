using Application.UseCase.Products.CreateProduct;
using Application.UseCase.Products.DeleteProduct;
using Application.UseCase.Products.GetProduct;
using Application.UseCase.Products.UpdateProduct;
using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController(
    ICreateProductUseCase createProductUseCase,
    IDeleteProductUseCase deleteProductUseCase,
    IGetProductUseCase getProductUseCase,
    IUpdateProductUseCase updateProductUseCase) : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult Create(CreateProductInputDto dto)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return Ok();
    }

    [HttpPut]
    public IActionResult Update(UpdateProductInputDto dto)
    {
        return Ok();
    }
}