using Aplication.UseCase;
using Microsoft.AspNetCore.Mvc;

[Route("api/veiculos/relatorio")]
[ApiController]
public class RelatorioController : ControllerBase
{
    private readonly SomaValorUseCase _useCase;

    public RelatorioController(SomaValorUseCase usecase)
    {
        _useCase = usecase;
    }

    [HttpGet("relatorio")]
    public IActionResult RelatorioLucro([FromQuery] DateTime datainicial, [FromQuery] DateTime dataFinal)
    {
        var response = _useCase.Execute(datainicial, dataFinal);
        if (response == null) 
            return BadRequest(response.Mensagem);

        return Ok(response);
    }
}

