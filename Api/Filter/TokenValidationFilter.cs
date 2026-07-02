using Application.UseCase.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Practice.Filter;

public class TokenValidationFilter(IValidGuidUseCase validGuidUseCase) : IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        if (!context.HttpContext.Request.Headers.ContainsKey("token"))
        {
            context.Result = new UnauthorizedObjectResult(new { message = "Unauthorized" });
            return;
        }

        var token = context.HttpContext.Request.Headers["token"];
        if (string.IsNullOrEmpty(token))
        {
            context.Result = new UnauthorizedObjectResult(new { message = "Unauthorized" });
            return;
        }

        var isValid = await validGuidUseCase.ExecuteAsync(token!);
        if (!isValid)
        {
            context.Result = new UnauthorizedObjectResult(new { message = "Unauthorized" });
            return;
        }

        await next();
    }
}