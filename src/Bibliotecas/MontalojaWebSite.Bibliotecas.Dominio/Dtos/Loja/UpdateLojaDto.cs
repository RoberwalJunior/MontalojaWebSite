using System.ComponentModel.DataAnnotations;

namespace MontalojaWebSite.Bibliotecas.Dominio.Dtos.Loja;

public class UpdateLojaDto
{
    [Required]
    public string Nome { get; set; } = string.Empty!;
}
