var builder = WebApplication.CreateBuilder(args);

var application = builder.Build();

application.UseHttpsRedirection();

application.MapGet("/", () => "Hello World!");

application.Run();
