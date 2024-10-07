
using Microsoft.EntityFrameworkCore;
using todoApi.src.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddDbContext<ToDoContext>(option => option.UseInMemoryDatabase("TodoDatabase"));
builder.Services
    .AddGraphQLServer();

var app = builder.Build();

app.MapGraphQL();

app.MapGet("/", () => "Hello World!");

app.Run();

