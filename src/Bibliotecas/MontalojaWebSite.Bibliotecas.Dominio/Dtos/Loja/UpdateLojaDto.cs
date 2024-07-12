using System.ComponentModel.DataAnnotations;

namespace MontalojaWebSite.Bibliotecas.Dominio.Dtos.Loja;

public class UpdateLojaDto
{
    [Required(ErrorMessage = "Nome da Loja é obrigatório")]
    [StringLength(50, ErrorMessage = "Não pode conter mais do que 50 caracteres")]
    public string? Nome { get; set; }
}
