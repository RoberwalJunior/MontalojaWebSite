using AutoMapper;
using MontalojaWebSite.Bibliotecas.Dominio.Dtos.Loja;
using MontalojaWebSite.Bibliotecas.Dominio.Modelos;
using MontalojaWebSite.Bibliotecas.Infraestrutura.Dados;

namespace MontalojaWebSite.API.Services;

public class LojaService(IMapper mapper, DAL<Loja> dal)
{
    private readonly IMapper _mapper = mapper;
    private readonly DAL<Loja> _dal = dal;

    public List<ReadLojaDto> RecuperarLojas()
    {
        var lojas = _dal.Listar();
        return _mapper.Map<List<ReadLojaDto>>(lojas);
    }

    public ReadLojaDto? RecuperarLojaPorId(int id)
    {
        var loja = _dal.RecuperarPor(x => x.Id == id);
        return loja != null ? _mapper.Map<ReadLojaDto>(loja) : null;
    }

    public void CadastrarLoja(CreateLojaDto lojaDto)
    {
        var loja = _mapper.Map<Loja>(lojaDto);
        _dal.Adicionar(loja);
    }

    public bool AtualizarLoja(int id, UpdateLojaDto lojaDto)
    {
        var loja = _dal.RecuperarPor(x => x.Id == id);
        if (loja == null) return false;
        _mapper.Map(lojaDto, loja);
        _dal.Atualizar(loja);
        return true;
    }

    public bool ExcluirLoja(int id)
    {
        var loja = _dal.RecuperarPor(x => x.Id == id);
        if (loja == null) return false;
        _dal.Deletar(loja);
        return true;
    }
}
