using AutoMapper;
using MontalojaWebSite.Bibliotecas.Dominio.Dtos.Movel;
using MontalojaWebSite.Bibliotecas.Dominio.Modelos;
using MontalojaWebSite.Bibliotecas.Infraestrutura.Dados;

namespace MontalojaWebSite.API.Services;

public class MovelService(IMapper mapper, DAL<Movel> dal)
{
    private readonly IMapper _mapper = mapper;
    private readonly DAL<Movel> _dal = dal;

    public List<ReadMovelDto> RecuperarMoveis()
    {
        var moveis = _dal.Listar();
        return _mapper.Map<List<ReadMovelDto>>(moveis);
    }

    public ReadMovelDto? RecuperarMovelPorId(int id)
    {
        var movel = _dal.RecuperarPor(x => x.Id == id);
        return movel != null ? _mapper.Map<ReadMovelDto>(movel) : null;
    }

    public void CadastrarMovel(CreateMovelDto movelDto)
    {
        var movel = _mapper.Map<Movel>(movelDto);
        _dal.Adicionar(movel);
    }

    public bool AtualizarMovel(int id, UpdateMovelDto movelDto)
    {
        var movel = _dal.RecuperarPor(x => x.Id == id);
        if (movel == null) return false;
        _mapper.Map(movelDto, movel);
        _dal.Atualizar(movel);
        return true;
    }

    public bool ExcluirMovel(int id)
    {
        var movel = _dal.RecuperarPor(x => x.Id == id);
        if (movel == null) return false;
        _dal.Deletar(movel);
        return true;
    }
}
