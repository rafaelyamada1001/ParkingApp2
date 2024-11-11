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

        public List<VeiculosDTO> Execute()
        {
            var veiculos = _veiculosRepository.ListarVeiculos();            
            return veiculos;
        }
    }
}
