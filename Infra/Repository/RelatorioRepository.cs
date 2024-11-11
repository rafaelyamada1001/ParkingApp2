using Aplication.Interface;
using MySql.Data.MySqlClient;

namespace Infra.Repository
{
    public class RelatorioRepository : IRelatorioRepositoy
    {
        string connectionString = DataBaseConnection.StringConnection();
        public void RelatorioLucro(DateTime horaInicial, DateTime horaFinal)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT sum(valor) as valorTotal, count(valor) as movTotal FROM movger WHERE HoraSaida BETWEEN (@DataInical AND @DataFinal);";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@DataInicial", horaInicial);
                    command.Parameters.AddWithValue("@DataFinal", horaFinal);

                    command.ExecuteNonQuery();

                }
            }
        }
    }
}
