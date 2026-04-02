var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from Auto-Deploy!");
app.MapGet("/health", () => new { status = "ok", timestamp = DateTime.UtcNow });
app.MapGet("/version", () => new { version = "1.0.0", commit = Environment.GetEnvironmentVariable("GITHUB_SHA") ?? "local" });

app.Run();