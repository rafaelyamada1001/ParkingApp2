using Aplication.DTO;
using Domain.Entities;


namespace Aplication.Interface
{
    public interface IVeiculoRepository
    {
        void AdicionarVeiculo(Veiculos veiculo);
        void RemoverVeiculo(string placa, DateTime horaSaida, double horasEstacionadas, double minutosEstacionados, decimal Valor);
        List<VeiculosDTO> ListarVeiculos();
        int VagasDesocupadas(Estacionamento estacionamento);
        int VerificarPlaca(string placa);
        DateTime VerificarPermanencia(string placa);
    }
}
