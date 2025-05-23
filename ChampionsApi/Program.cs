using ChampionsApi;
using ChampionsApi.Graphql;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configurar DbContext
builder.Services.AddDbContext<ChampionsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configurar GraphQL con Hot Chocolate
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<PlayerStatType>() // <-- Aqu�
    .AddProjections()
    .AddFiltering()
    .AddSorting();

var app = builder.Build();

// Middleware para desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.Urls.Add("http://+:80");
}


// Agregar el endpoint de GraphQL
app.MapGraphQL("/graphql"); // Este es el endpoint principal de Hot Chocolate

app.Run();
