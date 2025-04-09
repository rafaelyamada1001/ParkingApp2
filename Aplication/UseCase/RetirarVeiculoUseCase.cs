using Aplication.DTO;
using Aplication.Interface;

namespace Aplication.UseCase
{
    public class RetirarVeiculoUseCase
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public RetirarVeiculoUseCase(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public ResponseDefault<string> Execute(string placa, DateTime horaSaida, int horasEstacionadas, int minutosEstacionados, decimal valorTotal)
        {
            var verificarPlaca = _veiculoRepository.VerificarPlaca(placa);

            if (!verificarPlaca.Sucesso || verificarPlaca.Dados < 1)
                return new ResponseDefault<string>(false, $"Placa: {placa} não encontrada", null);

            var result = _veiculoRepository.RemoverVeiculo(placa, horaSaida, horasEstacionadas, minutosEstacionados, valorTotal);

            if (!result.Sucesso)
                return new ResponseDefault<string>(false, result.Mensagem, null);

            return new ResponseDefault<string>(true, $"Veículo {placa} removido com sucesso!", null);
        }
    }
}
