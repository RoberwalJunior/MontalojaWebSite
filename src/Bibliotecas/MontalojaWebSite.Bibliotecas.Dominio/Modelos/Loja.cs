using System.ComponentModel.DataAnnotations;

namespace MontalojaWebSite.Bibliotecas.Dominio.Modelos;

public class Loja
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string? Nome { get; set; }

    [Required]
    public int ClienteId { get; set; }
    public virtual Cliente? Cliente { get; set; }

    public virtual ICollection<Movel>? Moveis { get; set; }
}
