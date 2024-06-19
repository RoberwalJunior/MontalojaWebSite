namespace MontalojaWebSite.Bibliotecas.Dominio.Dtos.Movel;

public class ReadMovelDto
{
    public int Id { get; set; }
    public int LojaId { get; set; }
    public string Nome { get; set; } = string.Empty!;
}
