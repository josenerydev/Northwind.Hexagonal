using Northwind.Application.Commands.CreateCategory;
using Northwind.Application.Queries;
using Northwind.Application.Repositories;
using Northwind.Infrastructure.Queries;
using Northwind.Infrastructure.Repositories;

using Raven.Client.Documents;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IDocumentStore>(ctx =>
{
    IDocumentStore store = new DocumentStore
    {
        Urls = new[] { "http://localhost:8080" },
        Database = "Northwind"
    };

    store.Initialize();

    return store;
});

builder.Services.AddScoped<ICategoriesQueries, CategoriesQueries>();
builder.Services.AddScoped<ICategoryReadOnlyRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryWriteOnlyRepository, CategoryRepository>();
builder.Services.AddScoped<ICreateCategoryUseCase, CreateCategoryUseCase>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();