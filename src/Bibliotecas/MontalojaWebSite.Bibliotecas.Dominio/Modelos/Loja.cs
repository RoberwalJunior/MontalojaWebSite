namespace MontalojaWebSite.Bibliotecas.Dominio.Modelos;

public class Loja
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty!;
    public int ClienteId { get; set; }
    public virtual Cliente Cliente { get; set; } = null!;
    public virtual ICollection<Movel> Moveis { get; set; } = new List<Movel>();
}
