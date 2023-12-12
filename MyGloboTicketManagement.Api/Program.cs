using MyGloboTicketManagement.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Configure the HTTP request pipeline.
var app = builder.ConfigureServices().ConfigurePipeline();

await app.ResetDatabaseAsync();

app.Run();

