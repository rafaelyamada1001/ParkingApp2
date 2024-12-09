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
            var veiculo = new Veiculos(placa);

            if (!vagasTotaisResponse.Sucesso) return new ResponseDefault<string>(false, vagasTotaisResponse.Mensagem, null);

            var vagas = vagasTotaisResponse.Dados.VagasTotais;

            if (vagasOcupadas.Dados >= vagas)
            {
                return new ResponseDefault<string>(false, "Estacionamento cheio!", null);
            }

            if (!veiculo.Valid)
            {
                return new ResponseDefault<string>(false, veiculo.Notifications.First().Message, null);
            }

            var veiculosComMesmaPlaca = _veiculosRepository.VerificarPlaca(placa);

            if (veiculosComMesmaPlaca.Dados > 0)
            {
                return new ResponseDefault<string>(false, "Veículo já estacionado", null);

            }
            var adicionarVeiculo = _veiculosRepository.AdicionarVeiculo(veiculo);

            if (!adicionarVeiculo.Sucesso)
            {
                return new ResponseDefault<string>(false, adicionarVeiculo.Mensagem, null);
            }

            return new ResponseDefault<string>(true, adicionarVeiculo.Mensagem, placa);


        }
    }
}
