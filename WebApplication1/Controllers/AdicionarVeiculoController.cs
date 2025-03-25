using Microsoft.AspNetCore.Mvc;
using Aplication.UseCase;
using Aplication.Interface;
using ParkingApi.Models.Requests;

[Route("api/veiculos/adicionar")]
[ApiController]
public class AdicionarVeiculoController : ControllerBase
{
    private readonly AdicionarVeiculoUseCase _useCase;

    public AdicionarVeiculoController(IVeiculoRepository veiculoRepository, IEstacionamentoRepository estacionamentoRepository)
    {
        _useCase = new AdicionarVeiculoUseCase(veiculoRepository, estacionamentoRepository);
    }

    [HttpPost("adicionar")]
    public IActionResult AdicionarVeiculo([FromBody] AdicionarVeiculoRequest request)
    {
        if (request == null)
            return BadRequest("Dados inválidos.");

        var response = _useCase.Execute(request.Placa, request.TipoVeiculo);

        if (!response.Sucesso)
            return BadRequest(response.Mensagem);

        return Ok(new { message = response.Mensagem, placa = response.Dados });
    }
}
