using System.ComponentModel.DataAnnotations;

namespace MontalojaWebSite.Bibliotecas.Dominio.Dtos.Movel;

public class CreateMovelDto
{
    [Required(ErrorMessage = "Id da Loja é obrigatório")]
    public int LojaId { get; set; }

    [Required(ErrorMessage = "Nome do Movel é obrigatório")]
    [StringLength(50, ErrorMessage = "Não pode conter mais do que 50 caracteres")]
    public string? Nome { get; set; }
}
