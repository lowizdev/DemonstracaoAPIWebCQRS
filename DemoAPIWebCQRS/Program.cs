using DemoAPIWebCQRS.Commands;
using DemoAPIWebCQRS.Infrastructure;
using DemoAPIWebCQRS.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<InMemoryContext>();
builder.Services.AddScoped<ProdutoRepository>();

builder.Services.AddScoped<ICreateProdutoHandler, CreateProdutoHandler>();

builder.Services.AddScoped<QueryAllProdutos>();
builder.Services.AddScoped<QuerySingleProduto>();

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
