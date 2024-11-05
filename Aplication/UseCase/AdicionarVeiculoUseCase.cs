using Aplication.Interface;
using Domain.Entities;


namespace Aplication.UseCase
{
    public class AdicionarVeiculoUseCase
    {
        private readonly IVeiculoRepository _veiculosRepository;

        public AdicionarVeiculoUseCase(IVeiculoRepository veiculosRepository)
        {
            _veiculosRepository = veiculosRepository;
        }

        public void Execute(string placa)
        {

            if (string.IsNullOrEmpty(placa))
            {
                return;
            }

            var veiculosComMesmaPlaca = _veiculosRepository.VerificarPlaca(placa);

            if (veiculosComMesmaPlaca > 0)
            {
                return;
            }

            var veiculo = new Veiculos(placa, DateTime.Now);

            _veiculosRepository.AdicionarVeiculo(veiculo);
        }
    }
}
