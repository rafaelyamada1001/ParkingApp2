using Aplication.DTO;

namespace Aplication.Interface
{
    public interface IEstacionamentoRepository
    {
        ResponseDefault<VagasTotaisDTO> VagasTotais();
        ResponseDefault<TipoVagasDTO> VagasOcupadas();
        ResponseDefault<object> AtualizarDadosEstacionamento(VagasTotaisDTO dados);
    }
}
