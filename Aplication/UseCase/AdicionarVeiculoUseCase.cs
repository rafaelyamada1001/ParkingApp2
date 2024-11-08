using Aplication.DTO;
using Aplication.Interface;
using Domain.Entities;


namespace Aplication.UseCase
{
    public class AdicionarVeiculoUseCase
    {
        private readonly IVeiculoRepository _veiculosRepository;
        private readonly IEstacionamentoRepository _estacionamentoRepository;

        public AdicionarVeiculoUseCase
            (IVeiculoRepository veiculosRepository, IEstacionamentoRepository estacionamentoRepository)
        {
            _veiculosRepository = veiculosRepository;
            _estacionamentoRepository = estacionamentoRepository;
        }

        public ResponseDefault<string> ExecuteAdicionarVeiculo(string placa)
        {
            var vagasOcupadas = _estacionamentoRepository.VagasOcupadas();
            var vagasTotaisResponse = _estacionamentoRepository.VagasTotais();

            if (!vagasTotaisResponse.Sucesso) return new ResponseDefault<string>(false, vagasTotaisResponse.Mensagem, null);

            int vagas = vagasTotaisResponse.Dados.VagasTotais;

            if (vagasOcupadas >= vagas)
            {
                string message = "Estacionamento cheio !";
                return message;
            }

            if (string.IsNullOrEmpty(placa))
            {
                string message = "Campo não pode ser vazio";
                return message;
            }

            var veiculosComMesmaPlaca = _veiculosRepository.VerificarPlaca(placa);

            if (veiculosComMesmaPlaca > 0)
            {
                string message = "Veículo já estacionado !";
                return message;
            }
            else
            {

                var veiculo = new Veiculos(placa, DateTime.Now);

                _veiculosRepository.AdicionarVeiculo(veiculo);

                string message = $"Veículo com a placa: {placa} estacionado com sucesso!";
                return message;
            }            
        }
    }
}
