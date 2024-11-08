using Aplication.DTO;
using Aplication.Interface;
using System.Numerics;


namespace Aplication.UseCase
{
    public class RemoverVeiculoUseCase
    {
        private readonly IVeiculoRepository _veiculosRepository;
        private readonly IEstacionamentoRepository _estacionamentoRepository;

        public RemoverVeiculoUseCase
            (IVeiculoRepository veiculosRepository, IEstacionamentoRepository estacionamentoRepository)
        {
            _veiculosRepository = veiculosRepository;
            _estacionamentoRepository = estacionamentoRepository;
        }

        public string ExecuteRemoverVeiculo(string placa)
        {

            var vagasTotaisDTO = _estacionamentoRepository.VagasTotais();
            var horaEntrada = _veiculosRepository.VerificarPermanencia(placa);
            var verificarPlaca = _veiculosRepository.VerificarPlaca(placa);

            decimal valorHora = vagasTotaisDTO.ValorHora;

            var horaSaida = DateTime.Now;
            var tempoEstacionado = horaSaida - horaEntrada;
            var horasEstacionadas = tempoEstacionado.Hours;
            var minutosEstacionados = tempoEstacionado.Minutes;
            var valorTotal = (horasEstacionadas * valorHora) + (minutosEstacionados * (valorHora / 60m));


            if (verificarPlaca < 1)
            {
                string message = $"Placa{placa} de Veículo não encontrada";
                return message;
            }
            else
            {
                _veiculosRepository.RemoverVeiculo(placa, horaSaida, horasEstacionadas, minutosEstacionados, valorTotal);
                string message = $"Veículo Removido com sucesso!\n" +
                     $"Entrada: {horaEntrada} | Saída: {horaSaida}\n" +
                     $"Valor Total: R${valorTotal:F2} | " +
                     $"Horas Estacionadas: {horasEstacionadas}h {minutosEstacionados}min Valor Hora:{valorHora}";
                return message;              
            }

            //return new SaidaVeiculoDTO(placa, valorTotal)
            //{
            //    Placa = placa,
            //    ValorTotal = valorTotal,
            //};

        }
    }
}
