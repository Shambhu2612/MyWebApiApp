namespace MyWebApiApp.Api.Middlewares
{
    public class MyCustomMiddleWare
    {
        private readonly RequestDelegate _next;

        public MyCustomMiddleWare(RequestDelegate next)
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
