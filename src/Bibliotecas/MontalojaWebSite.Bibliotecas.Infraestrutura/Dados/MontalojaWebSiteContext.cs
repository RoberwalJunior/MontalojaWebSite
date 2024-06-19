using Microsoft.EntityFrameworkCore;
using MontalojaWebSite.Bibliotecas.Dominio.Modelos;

namespace MontalojaWebSite.Bibliotecas.Infraestrutura.Dados;

public class MontalojaWebSiteContext : DbContext
{
    public MontalojaWebSiteContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Loja> Lojas { get; set; }
    public DbSet<Movel> Moveis { get; set; }
}
