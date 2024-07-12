using System.ComponentModel.DataAnnotations;

namespace MontalojaWebSite.Bibliotecas.Dominio.Dtos.Cliente;

public class CreateClienteDto
{
    [Required(ErrorMessage = "Nome do cliente é obrigatório")]
    [StringLength(50, ErrorMessage = "Não pode conter mais do que 50 caracteres")]
    public string? Nome { get; set; }
}
