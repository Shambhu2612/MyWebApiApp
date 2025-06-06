using MyWebApiApp.Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseMiddleware<MyCustomMiddleWare>();
app.UseMiddleware<ExceptionMiddleware>();
app.UseMiddleware<LoggerMiddleware>();
app.UseMiddleware<AuthenticationMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
