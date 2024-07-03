using Ordering.Api;
using Ordering.Application;
using Ordering.Infrastructure;
using Ordering.Infrastructure.Data.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddAPIServices();



var app = builder.Build();

// Configure the HTTP request pipeline.

app.useApiServices();
if (app.Environment.IsDevelopment())
{
    await app.InitaliseDatabaseAsync();
}

app.Run();
