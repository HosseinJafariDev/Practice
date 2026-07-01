namespace Application.UseCase.Auth.register;

public interface IRegisterUseCase
{
    Task<string> ExecuteAsync(RegisterUseCaseInput input);
}