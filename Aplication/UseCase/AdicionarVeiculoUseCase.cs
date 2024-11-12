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

        public ResponseDefault<string> Execute(string placa)
        {
            var vagasOcupadas = _estacionamentoRepository.VagasOcupadas();
            var vagasTotaisResponse = _estacionamentoRepository.VagasTotais();

            if (!vagasTotaisResponse.Sucesso) return new ResponseDefault<string>(false, vagasTotaisResponse.Mensagem, null);

            var vagas = vagasTotaisResponse.Dados.VagasTotais;

            if (vagasOcupadas.Dados >= vagas)
            {
                return new ResponseDefault<string>(false, "Estacionamento cheio!", null);
            }

            if (string.IsNullOrEmpty(placa))
            {
                return new ResponseDefault<string>(false, "Campo não pode ser vazio", null);
            }

            var veiculosComMesmaPlaca = _veiculosRepository.VerificarPlaca(placa);

            if (veiculosComMesmaPlaca.Dados > 0)
            {
                return new ResponseDefault<string>(false, "Veículo já estacionado", null);

            }
            else
            {

                var veiculo = new Veiculos(placa, DateTime.Now);

                _veiculosRepository.AdicionarVeiculo(veiculo);

                return new ResponseDefault<string>(true, "Veículo estacionado com sucesso!", null);
            }            
        }
    }
}
