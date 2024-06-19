namespace MontalojaWebSite.Bibliotecas.Dominio.Modelos;

public class Movel
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty!;
    public int LojaId { get; set; }
    public virtual Loja Loja { get; set; } = null!;
}
