using Wolverine;
using WolverineDualMiddleware;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseWolverine(_ => _.Handlers.AddMiddlewareByMessageType(typeof(SampleMiddleware)));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

public partial class Program { }