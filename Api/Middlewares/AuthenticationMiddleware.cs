using Application.UseCase.Auth;

namespace Practice.Middlewares;

public class AuthenticationMiddleware
{
    private readonly RequestDelegate _next;

    public AuthenticationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, IValidGuidUseCase validGuidUseCase)
    {
        if (context.Request.Path.StartsWithSegments("/api/Auth/register") ||
            context.Request.Path.StartsWithSegments("/api/Auth/Login"))
        {
            await _next(context);
            return;
        }


        if (!context.Request.Headers.ContainsKey("token"))
        {
            context.Response.StatusCode = 401;
            return;
        }

        var token = context.Request.Headers["token"];
        if (string.IsNullOrEmpty(token))
        {
            context.Response.StatusCode = 401;
            return;
        }

        var isValid = await validGuidUseCase.ExecuteAsync(token!);
        if (!isValid)
        {
            context.Response.StatusCode = 401;
            return;
        }

        await _next(context);
    }
}