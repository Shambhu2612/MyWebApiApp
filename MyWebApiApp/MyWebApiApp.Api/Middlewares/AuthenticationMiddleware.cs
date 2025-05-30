namespace MyWebApiApp.Api.Middlewares
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("before middleware call");
            await _next(context);
            Console.WriteLine("after middleware call");
        }
    }
}
