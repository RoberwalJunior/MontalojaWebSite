using System.ComponentModel.DataAnnotations;

namespace MontalojaWebSite.Bibliotecas.Dominio.Dtos.Movel;

public class UpdateMovelDto
{
    [Required]
    public string Nome { get; set; } = string.Empty!;
}
