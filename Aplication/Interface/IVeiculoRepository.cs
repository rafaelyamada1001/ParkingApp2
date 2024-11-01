using System;


namespace Aplication.Interface
{
    public interface IVeiculoRepository
    {
        void AdicionarVeiculo(string placa);
        void RemoverVeiculo(string placa);
        void ListarVeiculos();
        void VagasDesocupadas();
    }
}
