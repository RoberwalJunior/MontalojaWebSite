using Microsoft.AspNetCore.Mvc;
using MontalojaWebSite.API.Services;
using MontalojaWebSite.Bibliotecas.Dominio.Dtos.Cliente;

namespace MontalojaWebSite.API.Controllers;

[Route("[controller]")]
[ApiController]
public class ClientesController : ControllerBase
{
    private ClienteService _clienteService;

    public ClientesController(ClienteService service)
    {
        _clienteService = service;
    }

    [HttpGet]
    public IActionResult RecuperaClientes()
    {
        var clientesDtos = _clienteService.RecuperarClientes();
        return Ok(clientesDtos);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaClientePorId(int id)
    {
        var cliente = _clienteService.RecuperarClientePorId(id);
        if (cliente == null) return NotFound();

        return Ok(cliente);
    }

    [HttpPost]
    public IActionResult AdicionaCliente([FromBody] CreateClienteDto clienteDto)
    {
        _clienteService.CadastrarCliente(clienteDto);
        return Ok("Cliente Cadastrado com exito!");
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaCliente(int id, [FromBody] UpdateClienteDto clienteDto)
    {
        if (_clienteService.AtualizarCliente(id, clienteDto)) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaCliente(int id)
    {
        if (_clienteService.ExcluirCliente(id)) return NotFound();
        return NoContent();
    }
}
