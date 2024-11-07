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

        public void ExecuteRemoverVeiculo(string placa)
        {
            if (string.IsNullOrEmpty(placa))
            {
                return;
            }

            var teste = _estacionamentoRepository.VagasTotais();
            var horaEntrada = _veiculosRepository.VerificarPermanencia(placa);

            decimal valorHora = teste.ValorHora;

            var horaSaida = DateTime.Now;
            var tempoEstacionado = horaSaida - horaEntrada;
            var horasEstacionadas = tempoEstacionado.Hours;
            var minutosEstacionados = tempoEstacionado.Minutes;
            var valorMinuto = valorHora / 60;
            var valorTotal = valorMinuto * minutosEstacionados;

            _veiculosRepository.RemoverVeiculo(placa, horaSaida, horasEstacionadas, minutosEstacionados, valorTotal);

        }
    }
}
