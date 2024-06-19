namespace MontalojaWebSite.Bibliotecas.Dominio.Dtos.Loja;

public class ReadLojaDto
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public string Nome { get; set; } = string.Empty!;
}
