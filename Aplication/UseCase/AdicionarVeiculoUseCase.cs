using Aplication.DTO;
using Aplication.Interface;
using Domain.Entities;
using Domain.Validations.Interfaces;


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

            if (!veiculo.Validation())
            {
                return new ResponseDefault<string>(false, "A Placa não pode ser nula ou deve conter 7 caracteres", null);
            }

            var veiculosComMesmaPlaca = _veiculosRepository.VerificarPlaca(placa);

            if (veiculosComMesmaPlaca.Dados > 0)
            {
                return new ResponseDefault<string>(false, "Veículo já estacionado", null);

            }
<<<<<<< HEAD
            var adicionarVeiculo = _veiculosRepository.AdicionarVeiculo(veiculo);

            if (!adicionarVeiculo.Sucesso)
            {
                return new ResponseDefault<string>(false, adicionarVeiculo.Mensagem, null);
            }

            return new ResponseDefault<string>(true, adicionarVeiculo.Mensagem, placa);


=======

            var adicionarVeiculoResponse = _veiculosRepository.AdicionarVeiculo(veiculo);
            if (!adicionarVeiculoResponse.Sucesso)
            {
                return new ResponseDefault<string>(false, adicionarVeiculoResponse.Mensagem, null);
            }

            return new ResponseDefault<string>(true, "Veículo estacionado com sucesso!", null);
>>>>>>> 6ae504f46bf99ef56b2e1c4f2fa5f771f909b716
        }
    }
}
