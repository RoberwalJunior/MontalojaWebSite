using Microsoft.AspNetCore.Mvc;
using MontalojaWebSite.API.Services;
using MontalojaWebSite.Bibliotecas.Dominio.Dtos.Loja;

namespace MontalojaWebSite.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LojasController(LojaService lojaService) : ControllerBase
{
    private readonly LojaService _lojaService = lojaService;

    [HttpGet]
    public IActionResult RecuperaLojas()
    {
        return Ok(_lojaService.RecuperarLojas());
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaLojaPorId(int id)
    {
        var loja = _lojaService.RecuperarLojaPorId(id);
        return loja != null ? Ok(loja) : NotFound();
    }

    [HttpPost]
    public IActionResult AdicionaLoja([FromBody] CreateLojaDto lojaDto)
    {
        _lojaService.CadastrarLoja(lojaDto);
        return Ok("Loja Cadastrado com exito!");
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaLoja(int id, [FromBody] UpdateLojaDto lojaDto)
    {
        return _lojaService.AtualizarLoja(id, lojaDto) ? NoContent() : NotFound();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaLoja(int id)
    {
        return _lojaService.ExcluirLoja(id) ? NoContent() : NotFound();
    }
}
