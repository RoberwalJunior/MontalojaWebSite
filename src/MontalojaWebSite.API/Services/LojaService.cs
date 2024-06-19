using AutoMapper;
using MontalojaWebSite.Bibliotecas.Dominio.Dtos.Loja;
using MontalojaWebSite.Bibliotecas.Dominio.Modelos;
using MontalojaWebSite.Bibliotecas.Infraestrutura.Dados;

namespace MontalojaWebSite.API.Services;

public class LojaService
{
    private IMapper _mapper;
    private DAL<Loja> _dal;

    public LojaService(IMapper mapper, DAL<Loja> dal)
    {
        _mapper = mapper;
        _dal = dal;
    }

    public List<ReadLojaDto> RecuperarLojas()
    {
        var lojas = _dal.Listar();
        var lojasDtos = _mapper.Map<List<ReadLojaDto>>(lojas);
        return lojasDtos;
    }

    public ReadLojaDto? RecuperarLojaPorId(int id)
    {
        var loja = _dal.RecuperarPor(x => x.Id == id);
        return _mapper.Map<ReadLojaDto>(loja);
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
