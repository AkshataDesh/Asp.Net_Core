var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

//Minimam Log Level is from LogInformation till LogCritical
app.Logger.LogDebug("Debug Log");
app.Logger.LogInformation("Information Log");
app.Logger.LogWarning("Warning Log");
app.Logger.LogError("Error Log");
app.Logger.LogCritical("Critical Log");



app.MapGet("/", () => "Hello World!");

app.Run();
