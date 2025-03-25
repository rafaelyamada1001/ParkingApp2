using Microsoft.AspNetCore.Mvc;
using Aplication.UseCase;
using Aplication.Interface;
using ParkingApi.Models.Requests;

[Route("api/veiculos")]
[ApiController]
public class VeiculoController : ControllerBase
{
    private readonly RemoverVeiculoUseCase _removerVeiculoUseCase;

    public VeiculoController(IVeiculoRepository veiculoRepository, IEstacionamentoRepository estacionamentoRepository)
    {
        _removerVeiculoUseCase = new RemoverVeiculoUseCase(veiculoRepository, estacionamentoRepository);
    }

    [HttpDelete("remover")]
    public IActionResult RemoverVeiculo([FromBody] RemoverVeiculoRequest request)
    {
        if (request == null || string.IsNullOrWhiteSpace(request.Placa))
            return BadRequest("Placa inválida.");

        var response = _removerVeiculoUseCase.Execute(request.Placa);

        if (!response.Sucesso)
            return BadRequest(response.Mensagem);

        return Ok(new { message = response.Mensagem });
    }
}
