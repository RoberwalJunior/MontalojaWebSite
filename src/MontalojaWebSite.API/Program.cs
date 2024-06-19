using Microsoft.EntityFrameworkCore;
using MontalojaWebSite.Bibliotecas.Infraestrutura.Dados;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MontalojaWebSiteContext>((options) =>
{
    options
        .UseSqlServer(builder.Configuration.GetConnectionString("MontalojaDb"))
        .UseLazyLoadingProxies();
});

// Add services to the container.

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
