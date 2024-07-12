using System.ComponentModel.DataAnnotations;

namespace MontalojaWebSite.Bibliotecas.Dominio.Dtos.Movel;

public class UpdateMovelDto
{
    [Required(ErrorMessage = "Nome do Movel é obrigatório")]
    [StringLength(50, ErrorMessage = "Não pode conter mais do que 50 caracteres")]
    public string? Nome { get; set; }
}
