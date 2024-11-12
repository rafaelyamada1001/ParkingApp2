using Aplication.DTO;
using Domain.Entities;


namespace Aplication.Interface
{
    public interface IVeiculoRepository
    {
        void AdicionarVeiculo(Veiculos veiculo);
        void RemoverVeiculo(string placa, DateTime horaSaida, double horasEstacionadas, double minutosEstacionados, decimal Valor);
        ResponseDefault<List<VeiculosDTO>> ListarVeiculos();      
        ResponseDefault<int> VerificarPlaca(string placa);
        ResponseDefault<DateTime> VerificarPermanencia(string placa);
    }
}
