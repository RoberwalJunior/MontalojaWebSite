using System.ComponentModel.DataAnnotations;

namespace MontalojaWebSite.Bibliotecas.Dominio.Dtos.Loja;

public class CreateLojaDto
{
    [Required]
    public int ClienteId { get; set; }

    [Required]
    public string Nome { get; set; } = string.Empty!;
}
