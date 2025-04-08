using Aplication.UseCase;
using Microsoft.AspNetCore.Mvc;

[Route("api/veiculos/listaVeiculos")]
[ApiController]

public class ListarVeiculosController : ControllerBase
{
    private readonly ListarVeiculosUseCase _useCase;

    public ListarVeiculosController(ListarVeiculosUseCase useCase)
    {
        _useCase = useCase;
    }

    [HttpGet("listar")]
    public IActionResult ListarVeiculos()
    {
        var response = _useCase.Execute();
        if (response.Sucesso)
        {
            return Ok(new
            {
                sucesso = true,
                mensagem = response.Mensagem,
                dados = response.Dados,
            });
        }
        else
        {
            return NotFound(new
            {
                sucesso = false,
                mensagem = response.Mensagem
            });
        }
    }
}

