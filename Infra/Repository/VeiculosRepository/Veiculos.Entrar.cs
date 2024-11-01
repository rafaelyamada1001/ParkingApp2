using Domain.Entities;
using MySql.Data.MySqlClient;
using System;


namespace Infra.Repository.VeiculosRepository
{
    public class VeiculosEntrar
    {
        private string connectionString = "Server=localhost;Database=teste;User ID=root;Password=1234;";

        public void EntradaVeiculo(Veiculos veiculo)
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
    }
}
