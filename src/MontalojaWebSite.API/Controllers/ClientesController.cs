using Microsoft.AspNetCore.Mvc;
using MontalojaWebSite.API.Services;
using MontalojaWebSite.Bibliotecas.Dominio.Dtos.Cliente;

namespace MontalojaWebSite.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientesController(ClienteService service) : ControllerBase
{
    private readonly ClienteService _clienteService = service;

    [HttpGet]
    public IActionResult RecuperaClientes()
    {
        return Ok(_clienteService.RecuperarClientes());
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaClientePorId(int id)
    {
        var cliente = _clienteService.RecuperarClientePorId(id);
        return cliente != null ? Ok(cliente) : NotFound();
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
        return _clienteService.AtualizarCliente(id, clienteDto) ? NoContent() : NotFound();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaCliente(int id)
    {
        return _clienteService.ExcluirCliente(id) ? NoContent() : NotFound();
    }
}
