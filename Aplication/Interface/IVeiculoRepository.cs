using Domain.Entities;
using System;


namespace Aplication.Interface
{
    public interface IVeiculoRepository
    {
        void AdicionarVeiculo(Veiculos veiculo);
        void RemoverVeiculo(string placa);
        void ListarVeiculos();
        int VagasDesocupadas();
        int VerificarPlaca(string placa);
    }
}
