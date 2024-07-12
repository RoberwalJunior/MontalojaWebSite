using Microsoft.AspNetCore.Mvc;
using MontalojaWebSite.API.Services;
using MontalojaWebSite.Bibliotecas.Dominio.Dtos.Movel;

namespace MontalojaWebSite.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoveisController(MovelService movelService) : ControllerBase
{
    private readonly MovelService _movelService = movelService;

    [HttpGet]
    public IActionResult RecuperaMovels()
    {
        return Ok(_movelService.RecuperarMoveis());
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaMovelPorId(int id)
    {
        var movel = _movelService.RecuperarMovelPorId(id);
        return movel != null ? Ok(movel) : NotFound();
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
        return _movelService.AtualizarMovel(id, movelDto) ? NoContent() : NotFound();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaMovel(int id)
    {
        return _movelService.ExcluirMovel(id) ? NoContent() : NotFound();
    }
}
