using System.ComponentModel.DataAnnotations;

namespace MontalojaWebSite.Bibliotecas.Dominio.Modelos;

public class Cliente
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string? Nome { get; set; }

    public virtual ICollection<Loja>? Lojas { get; set; }
}
