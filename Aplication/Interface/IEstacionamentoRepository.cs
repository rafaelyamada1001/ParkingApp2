

using Aplication.DTO;

namespace Aplication.Interface
{
    public interface IEstacionamentoRepository
    {
        VagasTotaisDTO VagasTotais();
        int VagasOcupadas();
    }
}
