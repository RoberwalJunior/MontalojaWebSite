using Microsoft.AspNetCore.Mvc;
using MontalojaWebSite.API.Services;
using MontalojaWebSite.Bibliotecas.Dominio.Dtos.Loja;

namespace MontalojaWebSite.API.Controllers;

[Route("[controller]")]
[ApiController]
public class LojasController : ControllerBase
{
    private LojaService _lojaService;

    public LojasController(LojaService lojaService)
    {
        _lojaService = lojaService;
    }

    [HttpGet]
    public IActionResult RecuperaLojas()
    {
        var lojasDtos = _lojaService.RecuperarLojas();
        return Ok(lojasDtos);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaLojaPorId(int id)
    {
        var loja = _lojaService.RecuperarLojaPorId(id);
        if (loja == null) return NotFound();

        return Ok(loja);
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
        if (_lojaService.AtualizarLoja(id, lojaDto)) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaLoja(int id)
    {
        if (_lojaService.ExcluirLoja(id)) return NotFound();
        return NoContent();
    }
}
