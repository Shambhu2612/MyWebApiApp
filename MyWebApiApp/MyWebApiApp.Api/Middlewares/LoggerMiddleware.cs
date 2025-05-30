namespace MyWebApiApp.Api.Middlewares
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggerMiddleware(RequestDelegate next)
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
