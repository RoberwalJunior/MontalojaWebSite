using System.ComponentModel.DataAnnotations;

namespace MontalojaWebSite.Bibliotecas.Dominio.Dtos.Movel;

public class CreateMovelDto
{
    [Required]
    public int LojaId { get; set; }

    [Required]
    public string Nome { get; set; } = string.Empty!;
}
