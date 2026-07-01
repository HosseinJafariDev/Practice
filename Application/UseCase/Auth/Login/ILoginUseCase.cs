namespace Application.UseCase.Auth.login;

public interface ILoginUseCase
{
    Task<string> ExecuteAsync(LoginUseCaseInput input);
}