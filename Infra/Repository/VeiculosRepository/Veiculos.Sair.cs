using MySql.Data.MySqlClient;

namespace Infra.Repository.VeiculosRepository
{
    public class VeiculosSair
    {
        private string connectionString = "Server=localhost;Database=teste;User ID=root;Password=1234;";
        public void SaidaVeiculo(string placa, DateTime horaSaida, double horasEstacionadas, double minutosEstacionados, decimal Valor)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string updateQuery =
                    "UPDATE MovGer SET HoraSaida = @HoraSaida, PermanenciaHora = @PermanenciaHora, PermanenciaMin = @PermanenciaMin, Valor = @Valor" +
                    " WHERE Placa = @Placa and HoraSaida is null";

                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Placa", placa);
                    command.Parameters.AddWithValue("@HoraSaida", horaSaida);
                    command.Parameters.AddWithValue("@PermanenciaHora", Math.Floor(horasEstacionadas));
                    command.Parameters.AddWithValue("@PermanenciaMin", minutosEstacionados);
                    command.Parameters.AddWithValue("@Valor", Valor.ToString("F2"));

                    command.ExecuteNonQuery();
                    command.ExecuteReader();
                }
            }
        }
    }
}
