var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // Adiciona suporte a controllers tradicionais
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Adiciona suporte para documentação Swagger/OpenAPI

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Habilita Swagger no ambiente de desenvolvimento
    app.UseSwaggerUI(); // Habilita a interface do Swagger UI
}

app.UseHttpsRedirection(); // Redireciona requisições HTTP para HTTPS

app.UseAuthorization(); // Habilita a autorização (se necessário)

app.MapControllers(); // Mapeia os controllers automaticamente

app.Run();