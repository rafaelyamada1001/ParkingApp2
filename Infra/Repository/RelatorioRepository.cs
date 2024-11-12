using Aplication.DTO;
using Aplication.Interface;
using MySql.Data.MySqlClient;

namespace Infra.Repository
{
    public class RelatorioRepository : IRelatorioRepositoy
    {
        string connectionString = DataBaseConnection.StringConnection();

        public ResponseDefault<decimal> RelatorioLucro(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT sum(valor) as valorTotal FROM movger WHERE HoraSaida BETWEEN @DataInicial AND @DataFinal;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DataInicial", dataInicial);
                        command.Parameters.AddWithValue("@DataFinal", dataFinal);

                        connection.Open();

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
            }
            catch (Exception ex)
            {
                var response = new ResponseDefault<Decimal>(false, ex.Message, 0);
                return response;
            }
        }
    }
}
