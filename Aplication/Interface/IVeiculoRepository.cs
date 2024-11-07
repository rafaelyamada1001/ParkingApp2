using Domain.Entities;
using System;


namespace Aplication.Interface
{
    public interface IVeiculoRepository
    {
        void AdicionarVeiculo(Veiculos veiculo);
        void RemoverVeiculo(string placa, DateTime horaSaida, double horasEstacionadas, double minutosEstacionados, decimal Valor);
        List<string> ListarVeiculos();
        int VagasDesocupadas(Estacionamento estacionamento);
        int VerificarPlaca(string placa);
        DateTime VerificarPermanencia(string placa);
    }
}
