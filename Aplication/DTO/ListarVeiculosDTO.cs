

namespace Aplication.DTO
{
    public class ListarVeiculosDTO
    {
        public List<VeiculosDTO> Veiculos { get; set; }

        public ListarVeiculosDTO(List<VeiculosDTO> veiculos)
        {
            Veiculos = veiculos;
        }
    }
}
