using Aplication.DTO;

namespace Aplication.Interface
{
    public interface IRelatorioRepositoy
    {
        ResponseDefault<decimal> RelatorioLucro(DateTime dataInicial, DateTime dataFinal);
        ResponseDefault<List<MovimentacaoDTO>> ObterMovimentoPorData(DateTime dataInicial, DateTime dataFinal);
    }
}
