using Application.UseCase.Auth.login;
using Application.UseCase.Auth.register;
using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController(ILoginUseCase loginUseCase, IRegisterUseCase registerUseCase) : ControllerBase
{
    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginUseCaseInput input)
    {
        var tokenId = await loginUseCase.ExecuteAsync(input);
        return Ok(new { token = $"{tokenId}" });
    }   

    [HttpPost("register")]
    public Task<IActionResult> Register([FromBody] RegisterUseCaseInput input)
    {
        throw new NotImplementedException();
    }
}