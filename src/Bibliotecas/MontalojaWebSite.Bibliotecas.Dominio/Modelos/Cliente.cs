namespace MontalojaWebSite.Bibliotecas.Dominio.Modelos;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty!;
    public virtual ICollection<Loja> Lojas { get; set; } = new List<Loja>();
}
