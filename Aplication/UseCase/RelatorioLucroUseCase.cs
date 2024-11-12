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

        public string Execute(DateTime dataInicial, DateTime dataFinal)
        {
            var valorTotal = _relatorioRepositoy.RelatorioLucro(dataInicial, dataFinal);

            if (valorTotal.Dados != 0)
            {
                string message = ($"Periodo selecionado: {dataInicial} - {dataFinal} \nValor: {valorTotal}");
                return message;
            }
            return null;
        }
    }
}
