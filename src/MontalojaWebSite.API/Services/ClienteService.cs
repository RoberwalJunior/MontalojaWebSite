using AutoMapper;
using MontalojaWebSite.Bibliotecas.Dominio.Dtos.Cliente;
using MontalojaWebSite.Bibliotecas.Dominio.Modelos;
using MontalojaWebSite.Bibliotecas.Infraestrutura.Dados;

namespace MontalojaWebSite.API.Services;

public class ClienteService(IMapper mapper, DAL<Cliente> dal)
{
    private readonly IMapper _mapper = mapper;
    private readonly DAL<Cliente> _dal = dal;

    public List<ReadClienteDto> RecuperarClientes()
    {
        var clientes = _dal.Listar();
        return _mapper.Map<List<ReadClienteDto>>(clientes);
    }

    public ReadClienteDto? RecuperarClientePorId(int id)
    {
        var cliente = _dal.RecuperarPor(x => x.Id == id);
        return cliente != null ? _mapper.Map<ReadClienteDto>(cliente) : null;
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
