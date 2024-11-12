using Aplication.DTO;
using Aplication.Interface;
using MySql.Data.MySqlClient;


namespace Infra.Repository
{
    public class EstacionamentoRepository : IEstacionamentoRepository
    {
        string connectionString = DataBaseConnection.StringConnection();

        public ResponseDefault<VagasTotaisDTO> VagasTotais()
        {
            var vagasTotais = 0;
            decimal valorHora = 0;

            try
            {
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
                                valorHora = reader.GetDecimal("ValorHora");
                                vagasTotais = reader.GetInt32("TotalVagas");
                            }
                            else
                            {
                                Console.WriteLine("Nenhum registro encontrado.");
                            }
                        }
                    }
                }

                var dto = new VagasTotaisDTO()
                {
                    VagasTotais = vagasTotais,
                    ValorHora = valorHora
                };

                var response = new ResponseDefault<VagasTotaisDTO>(true, "OK", dto);
                return response;
            }
            catch (Exception ex)
            {
                var response = new ResponseDefault<VagasTotaisDTO>(false, ex.Message, null);
                return response;
            }
        }

        public ResponseDefault<int> VagasOcupadas()
        {
            try
            {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT count(placa) as qtde FROM movger WHERE horasaida is null";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int vagasOcupadas = reader.GetInt32("qtde");
                                return new ResponseDefault<int>(true, "OK", vagasOcupadas);
                            }
                            return new ResponseDefault<int>(true, "Nenhuma vaga ocupada", 0);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                var response = new ResponseDefault<int>(false, ex.Message, 0);
                return response;
            }
        }
    }
}
