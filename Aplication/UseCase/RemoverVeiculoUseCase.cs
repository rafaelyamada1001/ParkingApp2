using Aplication.DTO;
using Aplication.Interface;

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

        public ResponseDefault<string> Execute(string placa)
        {

            var vagasTotaisDTO = _estacionamentoRepository.VagasTotais();
            var horaEntrada = _veiculosRepository.VerificarPermanencia(placa);
            var verificarPlaca = _veiculosRepository.VerificarPlaca(placa);

            if (!vagasTotaisDTO.Sucesso) return new ResponseDefault<string>(false, vagasTotaisDTO.Mensagem, null);
            if (!horaEntrada.Sucesso) return new ResponseDefault<string>(false, horaEntrada.Mensagem, null);
            if (!verificarPlaca.Sucesso) return new ResponseDefault<string>(false, verificarPlaca.Mensagem, null);

            decimal valorHora = vagasTotaisDTO.Dados.ValorHora;

            var horaSaida = DateTime.Now;
            var tempoEstacionado = horaSaida - horaEntrada.Dados;
            var horasEstacionadas = tempoEstacionado.Hours;
            var minutosEstacionados = tempoEstacionado.Minutes;
            var valorTotal = (horasEstacionadas * valorHora) + (minutosEstacionados * (valorHora / 60m));


            if (verificarPlaca.Dados < 1)
            {
                return new ResponseDefault<string>(false, $"Placa: {placa} de veículo não encontrada", null);
            }
            else
            {
                _veiculosRepository.RemoverVeiculo(placa, horaSaida, horasEstacionadas, minutosEstacionados, valorTotal);
                string message = $"Veículo Removido com sucesso!\n" +
                     $"Entrada: {horaEntrada.Dados} | Saída: {horaSaida}\n" +
                     $"Valor Total: R${valorTotal:F2} | " +
                     $"Horas Estacionadas: {horasEstacionadas}h {minutosEstacionados}min";
                return new ResponseDefault<string>(true, message, null);           
            }

        }
    }
}
