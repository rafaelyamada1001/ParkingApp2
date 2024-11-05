using Aplication.Interface;
using Domain.Entities;
using MySql.Data.MySqlClient;


namespace Infra.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private string connectionString = "Server=localhost;Database=teste;User ID=root;Password=1234;";
        public void AdicionarVeiculo(Veiculos veiculo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string insertQuery = "INSERT INTO MovGer (Placa, HoraEntrada) " +
                    "VALUES (@Placa, @HoraEntrada)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Placa", veiculo.PlacaVeiculo);
                    command.Parameters.AddWithValue("@HoraEntrada", veiculo.HoraEntrada);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void ListarVeiculos()
        {
            throw new NotImplementedException();
        }

        public void RemoverVeiculo(string placa)
        {
            throw new NotImplementedException();
        }

        public int VagasDesocupadas()
        {
            throw new NotImplementedException();
        }

        public int VerificarPlaca(string placa)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string verificaPlacaQuery = "SELECT COUNT(placa) as qtde FROM movger WHERE placa = @placa AND horasaida IS NULL";
                using (MySqlCommand verificaPlacaCommand = new MySqlCommand(verificaPlacaQuery, connection))
                {
                    verificaPlacaCommand.Parameters.AddWithValue("@placa", placa);
                    int veiculosComMesmaPlaca = Convert.ToInt32(verificaPlacaCommand.ExecuteScalar());
                    return veiculosComMesmaPlaca;
                }
            }
        }
    }
}
