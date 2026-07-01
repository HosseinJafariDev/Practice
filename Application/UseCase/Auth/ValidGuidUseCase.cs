namespace Application.UseCase.Auth;

public class ValidGuidUseCase : IValidGuidUseCase
{
    public Task<bool> ExecuteAsync(string token)
    {
        return Task.FromResult(false);
        //throw new NotImplementedException();
    }
}