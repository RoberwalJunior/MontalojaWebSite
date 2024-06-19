using Microsoft.AspNetCore.Mvc;
using MontalojaWebSite.API.Services;
using MontalojaWebSite.Bibliotecas.Dominio.Dtos.Movel;

namespace MontalojaWebSite.API.Controllers;

[Route("[controller]")]
[ApiController]
public class MoveisController : ControllerBase
{
    private MovelService _movelService;

    public MoveisController(MovelService movelService)
    {
        _movelService = movelService;
    }

    [HttpGet]
    public IActionResult RecuperaMovels()
    {
        var moveisDtos = _movelService.RecuperarMoveis();
        return Ok(moveisDtos);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaMovelPorId(int id)
    {
        var movel = _movelService.RecuperarMovelPorId(id);
        if (movel == null) return NotFound();

        return Ok(movel);
    }

    [HttpPost]
    public IActionResult AdicionaMovel([FromBody] CreateMovelDto movelDto)
    {
        _movelService.CadastrarMovel(movelDto);
        return Ok("Movel Cadastrado com exito!");
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaMovel(int id, [FromBody] UpdateMovelDto movelDto)
    {
        if (_movelService.AtualizarMovel(id, movelDto)) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaMovel(int id)
    {
        if (_movelService.ExcluirMovel(id)) return NotFound();
        return NoContent();
    }
}
