using System.ComponentModel.DataAnnotations;

namespace MontalojaWebSite.Bibliotecas.Dominio.Modelos;

public class Movel
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string? Nome { get; set; }

    [Required]
    public int LojaId { get; set; }
    public virtual Loja? Loja { get; set; }
}
