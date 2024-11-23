var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao contêiner.
builder.Services.AddControllers();

var app = builder.Build();

// Configura o pipeline de requisições.
app.MapControllers();

app.Run();
