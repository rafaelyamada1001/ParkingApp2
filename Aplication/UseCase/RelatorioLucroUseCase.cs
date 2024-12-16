using Aplication.DTO;
using Aplication.Interface;

namespace Aplication.UseCase
{
    public class RelatorioLucroUseCase
    {
        private readonly IRelatorioRepositoy _relatorioRepositoy;

        public RelatorioLucroUseCase(IRelatorioRepositoy relatorioRepositoy)
        {
            _relatorioRepositoy = relatorioRepositoy;
        }

        public ResponseDefault<decimal> Execute(DateTime dataInicial, DateTime dataFinal)
        {
            var valorTotal = _relatorioRepositoy.RelatorioLucro(dataInicial, dataFinal);

            //if (!valorTotal.Sucesso) return new ResponseDefault<decimal>(true, valorTotal.Mensagem, 0);


            if (valorTotal.Dados != 0)
            {
                string message = ($"Período selecionado: {dataInicial.ToString("dd/MM/yyyy")} - {dataFinal.ToString("dd/MM/yyyy")} \nValor: {valorTotal.Dados}");
                return new ResponseDefault<decimal>(true, message, valorTotal.Dados);
            }
            else
            {
                string message = ("Período sem movimentação! Verificar Data Selecionada");
                return new ResponseDefault<decimal>(false, message, 0);
            }
        }
    }
}
