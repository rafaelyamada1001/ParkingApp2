using Aplication.DTO;
using Aplication.Interface;
using MySql.Data.MySqlClient;

namespace Infra.Repository
{
    public class RelatorioRepository : IRelatorioRepositoy
    {
        private readonly MySqlConnection _connection;

        public RelatorioRepository(IConnection connection)
        {
            _connection = connection.GetConnection();
        }
        string connectionString = DataBaseConnection.StringConnection();

        public ResponseDefault<decimal> RelatorioLucro(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {

                string query = "SELECT sum(valor) as valorTotal FROM movger WHERE HoraSaida BETWEEN @DataInicial AND @DataFinal;";
                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@DataInicial", dataInicial);
                    command.Parameters.AddWithValue("@DataFinal", dataFinal);


                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var valorTotal = reader.GetDecimal("valorTotal");
                            return new ResponseDefault<Decimal>(true, "OK", valorTotal);
                        }
                        return new ResponseDefault<decimal>(true, "Nenhum dado encontrado.", 0);
                    }
                }

            }
            catch (Exception ex)
            {
                var response = new ResponseDefault<Decimal>(false, ex.Message, 0);
                return response;
            }
        }
    }
}
