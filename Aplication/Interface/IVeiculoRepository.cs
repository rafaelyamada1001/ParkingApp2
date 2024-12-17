using Aplication.DTO;
using Domain.Entities;


namespace Aplication.Interface
{
    public interface IVeiculoRepository
    {
        ResponseDefault<bool> AdicionarVeiculo(Veiculos veiculo);
        ResponseDefault<bool> RemoverVeiculo(string placa, DateTime horaSaida, double horasEstacionadas, double minutosEstacionados, decimal Valor);
        ResponseDefault<List<VeiculosDTO>> ListarVeiculos();      
        ResponseDefault<int> VerificarPlaca(string placa);
        ResponseDefault<DateTime> VerificarPermanencia(string placa);
        ResponseDefault<string> TipoVeiculo(string placa);
    }
}
