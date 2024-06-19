using AutoMapper;
using MontalojaWebSite.Bibliotecas.Dominio.Dtos.Cliente;
using MontalojaWebSite.Bibliotecas.Dominio.Modelos;
using MontalojaWebSite.Bibliotecas.Infraestrutura.Dados;

namespace MontalojaWebSite.API.Services;

public class ClienteService
{
    private IMapper _mapper;
    private DAL<Cliente> _dal;

    public ClienteService(IMapper mapper, DAL<Cliente> dal)
    {
        _mapper = mapper;
        _dal = dal;
    }

    public List<ReadClienteDto> RecuperarClientes()
    {
        var clientes = _dal.Listar();
        var clientesDtos = _mapper.Map<List<ReadClienteDto>>(clientes);
        return clientesDtos;
    }

    public ReadClienteDto? RecuperarClientePorId(int id)
    {
        var cliente = _dal.RecuperarPor(x => x.Id == id);
        return _mapper.Map<ReadClienteDto>(cliente);
    }

    public void CadastrarCliente(CreateClienteDto clienteDto)
    {
        var cliente = _mapper.Map<Cliente>(clienteDto);
        _dal.Adicionar(cliente);
    }

    public bool AtualizarCliente(int id, UpdateClienteDto clienteDto)
    {
        var cliente = _dal.RecuperarPor(x => x.Id == id);
        if (cliente == null) return false;
        _mapper.Map(clienteDto, cliente);
        _dal.Atualizar(cliente);
        return true;
    }

    public bool ExcluirCliente(int id)
    {
        var cliente = _dal.RecuperarPor(x => x.Id == id);
        if (cliente == null) return false;
        _dal.Deletar(cliente);
        return true;
    }
}
