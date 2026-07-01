namespace Application.UseCase.Auth;

public interface IValidGuidUseCase
{
    public Task<bool> ExecuteAsync(string token);
}