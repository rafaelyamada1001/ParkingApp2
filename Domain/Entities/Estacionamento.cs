using MySql.Data.MySqlClient;
using System;


namespace Domain.Entities
{
    public class Estacionamento
    {
        public Estacionamento(int vagas, decimal valor)
        {

            string connectionString = "Server=localhost;Database=teste;User ID=root;Password=1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT TotalVagas, ValorHora FROM estacionamento";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            valor = reader.GetDecimal("ValorHora");
                            vagas = reader.GetInt32("TotalVagas");
                        }
                        else
                        {
                            Console.WriteLine("Nenhum registro encontrado.");
                            return;
                        }
                    }
                }
            }
            Vagas = vagas;
            this.valor = valor;
        }

        public int Vagas { get; set; }
        private decimal valor { get; set; }
    }
}
