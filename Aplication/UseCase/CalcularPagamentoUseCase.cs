using Aplication.DTO;
using Aplication.Interface;

namespace Aplication.UseCase
{
    public class CalcularPagamentoUseCase
    {
        private readonly IVeiculoRepository _veiculosRepository;
        private readonly IEstacionamentoRepository _estacionamentoRepository;

        public CalcularPagamentoUseCase(IVeiculoRepository veiculoRepository, IEstacionamentoRepository estacionamentoRepository)
        {
            _estacionamentoRepository = estacionamentoRepository;
            _veiculosRepository = veiculoRepository;
        }

        public ResponseDefault<PagamentoDTO> Execute(string placa)
        {
            var vagasTotaisDTO = _estacionamentoRepository.VagasTotais();
            var horaEntrada = _veiculosRepository.VerificarPermanencia(placa);
            var verificarPlaca = _veiculosRepository.VerificarPlaca(placa);
            var tipoVeiculo = _veiculosRepository.TipoVeiculo(placa);

            if (!vagasTotaisDTO.Sucesso) return new ResponseDefault<PagamentoDTO>(false, vagasTotaisDTO.Mensagem, null);
            if (!horaEntrada.Sucesso) return new ResponseDefault<PagamentoDTO>(false, horaEntrada.Mensagem, null);
            if (!verificarPlaca.Sucesso) return new ResponseDefault<PagamentoDTO>(false, verificarPlaca.Mensagem, null);

            var valorHora = vagasTotaisDTO.Dados.ValorHora;
            var horaSaida = DateTime.Now;
            var tempoEstacionado = horaSaida - horaEntrada.Dados;
            var horasEstacionadas = (int)tempoEstacionado.TotalHours;
            var minutosEstacionados = tempoEstacionado.Minutes;
            var tempoTotalEstacionadoEmMinutos = (horasEstacionadas * 60) + minutosEstacionados;

            decimal valorTotal = 0;
            int horasCobradas = 0;
            // Regra 1: menos de 15 minutos, não precisa pagar
            if (tempoTotalEstacionadoEmMinutos < 15)
            {
                valorTotal = 0;
            }
            else
            {
                horasCobradas = horasEstacionadas;
                if (minutosEstacionados > 15) horasCobradas++;
                valorTotal = horasCobradas * valorHora;

                if (tipoVeiculo.Sucesso && tipoVeiculo.Dados == "Moto")
                {
                    valorTotal *= 0.5m;
                }
            }

            var pagamentoInfo = new PagamentoDTO
            {
                Placa = placa,
                TipoVeiculo = tipoVeiculo.Dados,
                HoraEntrada = horaEntrada.Dados,
                HoraSaida = horaSaida,
                TempoEstacionado = tempoEstacionado,
                ValorTotal = valorTotal,
                HorasCobradas = horasCobradas,
            };

            return new ResponseDefault<PagamentoDTO>(true, "Pagamento calculado com sucesso.", pagamentoInfo);

        }
    }
}
