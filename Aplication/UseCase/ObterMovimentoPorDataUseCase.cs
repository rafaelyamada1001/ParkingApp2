using Aplication.DTO;
using Aplication.Interface;

namespace Aplication.UseCase
{
    public class ObterMovimentoPorDataUseCase
    {
        private readonly IRelatorioRepositoy _relatorioRepository;
        
        public ObterMovimentoPorDataUseCase(IRelatorioRepositoy relatorioRepositoy)
        {
            _relatorioRepository = relatorioRepositoy;
        }

        public ResponseDefault<List<MovimentacaoDTO>> Execute(DateTime dataInicial, DateTime dataFinal)
        {
            var movimentacao = _relatorioRepository.ObterMovimentoPorData(dataInicial, dataFinal);

            return movimentacao;
            
        }
    }
}
