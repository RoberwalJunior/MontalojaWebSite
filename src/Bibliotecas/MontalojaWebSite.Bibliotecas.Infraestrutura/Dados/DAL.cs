namespace MontalojaWebSite.Bibliotecas.Infraestrutura.Dados;

public class DAL<T> : IDisposable where T : class
{
    private readonly MontalojaWebSiteContext context;

    public DAL(MontalojaWebSiteContext context)
    {
        this.context = context;
    }

    public IEnumerable<T> Listar()
    {
        return context.Set<T>().ToList();
    }

    public T? RecuperarPor(Func<T, bool> condicao)
    {
        return context.Set<T>().FirstOrDefault(condicao);
    }

    public void Adicionar(T objeto)
    {
        context.Set<T>().Add(objeto);
        context.SaveChanges();
    }

    public void Atualizar(T objeto)
    {
        context.Set<T>().Update(objeto);
        context.SaveChanges();
    }

    public void Deletar(T objeto)
    {
        context.Set<T>().Remove(objeto);
        context.SaveChanges();
    }

    public void Dispose()
    {
        context.Dispose();
    }
}
