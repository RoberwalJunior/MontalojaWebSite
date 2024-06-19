using Microsoft.EntityFrameworkCore;
using MontalojaWebSite.API.Services;
using MontalojaWebSite.Bibliotecas.Dominio.Modelos;
using MontalojaWebSite.Bibliotecas.Infraestrutura.Dados;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MontalojaWebSiteContext>((options) =>
{
    options
        .UseSqlServer(builder.Configuration.GetConnectionString("MontalojaDb"))
        .UseLazyLoadingProxies();
});

//Para usar o serviço do AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddTransient<DAL<Cliente>>();
builder.Services.AddTransient<DAL<Loja>>();
builder.Services.AddTransient<DAL<Movel>>();

builder.Services.AddTransient<ClienteService>();
builder.Services.AddTransient<LojaService>();
builder.Services.AddTransient<MovelService>();

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
