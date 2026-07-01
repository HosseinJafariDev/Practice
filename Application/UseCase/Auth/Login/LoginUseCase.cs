namespace Application.UseCase.Auth.login;

public class LoginUseCase : ILoginUseCase
{
    public Task<string> ExecuteAsync(LoginUseCaseInput input)
    {
        var guid = Guid.NewGuid();
        return Task.FromResult(guid.ToString());
    }
}