using Aplication.DTO;
using Aplication.Interface;
using Domain.Enums;

namespace Aplication.UseCase
{
    public class RemoverVeiculoUseCase
    {
        private readonly IVeiculoRepository _veiculosRepository;
        private readonly IEstacionamentoRepository _estacionamentoRepository;

        public RemoverVeiculoUseCase(IVeiculoRepository veiculosRepository, IEstacionamentoRepository estacionamentoRepository)
        {
            _veiculosRepository = veiculosRepository;
            _estacionamentoRepository = estacionamentoRepository;
        }

        public ResponseDefault<string> Execute(string placa)
        {
            var vagasTotaisDTO = _estacionamentoRepository.VagasTotais();
            var horaEntrada = _veiculosRepository.VerificarPermanencia(placa);
            var verificarPlaca = _veiculosRepository.VerificarPlaca(placa);
            var tipoVeiculo = _veiculosRepository.TipoVeiculo(placa);


            if (!vagasTotaisDTO.Sucesso) return new ResponseDefault<string>(false, vagasTotaisDTO.Mensagem, null);
            if (!horaEntrada.Sucesso) return new ResponseDefault<string>(false, horaEntrada.Mensagem, null);
            if (!verificarPlaca.Sucesso) return new ResponseDefault<string>(false, verificarPlaca.Mensagem, null);

            var valorHora = vagasTotaisDTO.Dados.ValorHora;

            var horaSaida = DateTime.Now;
            var tempoEstacionado = horaSaida - horaEntrada.Dados;
            var horasEstacionadas = tempoEstacionado.Hours;
            var minutosEstacionados = tempoEstacionado.Minutes;
            

            // Calcula o tempo total estacionado em minutos
            var tempoTotalEstacionadoEmMinutos = (horasEstacionadas * 60) + minutosEstacionados;

            // Regra 1: menos de 15 minutos, não precisa pagar
            if (tempoTotalEstacionadoEmMinutos < 15)
            {
                if (verificarPlaca.Dados < 1)
                {
                    return new ResponseDefault<string>(false, $"Placa: {placa} de veículo não encontrada", null);
                }
                else
                {
                    _veiculosRepository.RemoverVeiculo(placa, horaSaida, 0, minutosEstacionados, 0);
                    string message = $"Veículo Removido com sucesso!\n" +
                        $"Entrada: {horaEntrada.Dados} / Saída: {horaSaida}\n" +
                        $"Nenhuma cobrança aplicada (tempo inferior a 15 minutos).";
                    return new ResponseDefault<string>(true, message, null);
                }
            }

            // Regra 2: Após 15 minutos, cobra mais 1 hora
            var horasCobradas = horasEstacionadas;
            if (minutosEstacionados > 15) horasCobradas++;

            var valorTotal = horasCobradas * valorHora;

            //aplicando devido desconto quando o tipo do veículo é moto
            if (tipoVeiculo.Sucesso && tipoVeiculo.Dados == "Moto")
            {
                valorTotal *= 0.5m;
            }

            if (verificarPlaca.Dados < 1)
            {
                return new ResponseDefault<string>(false, $"Placa:{placa} de veículo não encontrada", null);
            }
            else
            {
                _veiculosRepository.RemoverVeiculo(placa, horaSaida, horasEstacionadas, minutosEstacionados, valorTotal);
                string message = $"Veículo Removido com sucesso!\n" +
                    $"Entrada: {horaEntrada.Dados} - Saída: {horaSaida}\n" +
                    $"Valor Total: R${valorTotal:F2} \n" +
                    $"Horas Cobradas: {horasCobradas}h \n" +
                    $"Tempo Estacionado: {horasEstacionadas}h {minutosEstacionados}min";
                return new ResponseDefault<string>(true, message, null);
            }
        }

    }
}

