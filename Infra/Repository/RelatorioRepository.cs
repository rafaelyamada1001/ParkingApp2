using Aplication.DTO;
using Aplication.Interface;
using Dapper;
using Infra.Connection;

namespace Infra.Repository
{
    public class RelatorioRepository : IRelatorioRepositoy
    {
        private readonly DatabaseConnection _connection;

        public RelatorioRepository(DatabaseConnection connection)
        {
            _connection = connection;
        }

        public ResponseDefault<decimal> RelatorioLucro(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                string query = "SELECT sum(valor) as valorTotal FROM movger WHERE HoraSaida BETWEEN @DataInicial AND @DataFinal;";

                using (var connection = _connection.OpenConnection())
                {                    
                    decimal valorTotal = connection.QueryFirstOrDefault<decimal>(query, new { DataInicial = dataInicial, DataFinal = dataFinal });

                    return new ResponseDefault<decimal>(true, "OK", valorTotal);
                }

            }
            catch (Exception ex)
            {
                var response = new ResponseDefault<decimal>(false, ex.Message, 0);
                return response;
            }
        }

        public ResponseDefault<List<MovimentacaoDTO>> ObterMovimentoPorData(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                string query = @"SELECT * FROM movger WHERE HoraSaida IS NOT NULL AND HoraSaida BETWEEN @DataInicial AND @DataFinal ORDER BY HoraSaida DESC";

                using (var connection = _connection.OpenConnection())
                {
                    var movimentacoes = connection.Query<MovimentacaoDTO>(query, new { DataInicial = dataInicial, DataFinal = dataFinal }).ToList();

                    return new ResponseDefault<List<MovimentacaoDTO>>(true, "OK", movimentacoes);
                }
            }
            catch(Exception ex)
            {
                return new ResponseDefault<List<MovimentacaoDTO>>(false, ex.Message, null);
            }
        }
    }
}
