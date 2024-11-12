using Aplication.DTO;
using Aplication.Interface;

namespace Aplication.UseCase
{
    public class ListarVeiculosUseCase
    {
        private readonly IVeiculoRepository _veiculosRepository;

        public ListarVeiculosUseCase(IVeiculoRepository veiculosRepository)
        {
            _veiculosRepository = veiculosRepository;
        }

        public ResponseDefault<List<VeiculosDTO>> Execute()
        {

            var veiculos = _veiculosRepository.ListarVeiculos();

            if (!veiculos.Sucesso) return new ResponseDefault<List<VeiculosDTO>>(false, veiculos.Mensagem, null);

            if (veiculos.Dados != null)
            {
            string message = "Veículos estacionados: \n";
            foreach (var veiculo in veiculos.Dados)
            {
                message += $" Veículo: {veiculo.Placa} - Hora Entrada: {veiculo.HoraEntrada}\n";
            }

                return new ResponseDefault<List<VeiculosDTO>>(true, $"{message}", veiculos.Dados);
            }
            else
            {
                return new ResponseDefault<List<VeiculosDTO>>(false, "Nenhum Veículo Estacionado", null);
            }


        }
    }
}
