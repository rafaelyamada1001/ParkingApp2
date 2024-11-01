using Aplication.Interface;
using MySql.Data.MySqlClient;

namespace Infra.Repository
{
    public class EstacionamentoRepository : IVeiculoRepository
    {
         private string connectionString = "Server=localhost;Database=teste;User ID=root;Password=1234;";
        public void AdicionarVeiculo(string placa)
        {
            throw new NotImplementedException();
        }

        public void ListarVeiculos()
        {
            throw new NotImplementedException();
        }

        public void RemoverVeiculo(string placa)
        {
            throw new NotImplementedException();
        }

        public void VagasDesocupadas()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT count(placa) as qtde FROM movger WHERE horasaida is null";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            string message = ($"Vagas Desocupadas:{Vagas}");
                            MessageBox.Show(message);
                            return;
                        }

                        int vagasOcupadas = reader.GetInt32("qtde");
                        var vagasLivres = Vagas - vagasOcupadas;
                        string messageVagasLivres = ($"Vagas Disponíveis: {vagasLivres}");
                        MessageBox.Show(messageVagasLivres);
                    }
                }
            }
        }
    }
}
