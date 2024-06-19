using AutoMapper;
using MontalojaWebSite.Bibliotecas.Dominio.Dtos.Movel;
using MontalojaWebSite.Bibliotecas.Dominio.Modelos;
using MontalojaWebSite.Bibliotecas.Infraestrutura.Dados;

namespace MontalojaWebSite.API.Services;

public class MovelService
{
    private IMapper _mapper;
    private DAL<Movel> _dal;

    public MovelService(IMapper mapper, DAL<Movel> dal)
    {
        _mapper = mapper;
        _dal = dal;
    }

    public List<ReadMovelDto> RecuperarMoveis()
    {
        var moveis = _dal.Listar();
        var moveisDtos = _mapper.Map<List<ReadMovelDto>>(moveis);
        return moveisDtos;
    }

    public ReadMovelDto? RecuperarMovelPorId(int id)
    {
        var movel = _dal.RecuperarPor(x => x.Id == id);
        return _mapper.Map<ReadMovelDto>(movel);
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
