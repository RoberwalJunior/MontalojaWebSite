using System.ComponentModel.DataAnnotations;

namespace MontalojaWebSite.Bibliotecas.Dominio.Dtos.Cliente;

public class UpdateClienteDto
{
    [Required]
    public string Nome { get; set; } = string.Empty!;
}
