using Aplication.DTO;
using Aplication.Interface;
using Domain.Entities;
using MySql.Data.MySqlClient;


namespace Infra.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        string connectionString = DataBaseConnection.StringConnection();

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

        public ResponseDefault<List<VeiculosDTO>> ListarVeiculos()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT placa, HoraEntrada FROM movger WHERE horasaida is null";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                List<VeiculosDTO> veiculos = new List<VeiculosDTO>();
                                while (reader.Read())
                                {
                                    string placa = reader.GetString("placa");
                                    DateTime horaEntrada = reader.GetDateTime("HoraEntrada");
                                    var veiculo = new VeiculosDTO(placa, horaEntrada);
                                    veiculos.Add(veiculo);
                                }
                                return new ResponseDefault<List<VeiculosDTO>>(true, "OK", veiculos);
                            }
                            else
                            {

                            return new ResponseDefault<List<VeiculosDTO>>(false, "Nenhum Veículo Encontrado", null); ;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                var response = new ResponseDefault<List<VeiculosDTO>>(false, ex.Message, null);
                return response;
            }
        }

        public void RemoverVeiculo(string placa, DateTime horaSaida, double horasEstacionadas, double minutosEstacionados, decimal Valor)
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
                    command.Parameters.AddWithValue("@Valor", Valor);

                    command.ExecuteNonQuery();
                    command.ExecuteReader();
                }
            }
        }

        public ResponseDefault<DateTime> VerificarPermanencia(string placa)
        {
            try
            {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT placa, HoraEntrada FROM movger WHERE placa = @Placa and HoraSaida is null";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Placa", placa);
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DateTime horaEntrada = reader.GetDateTime("HoraEntrada");
                                return new ResponseDefault<DateTime>(true, "OK", horaEntrada);
                            }
                            else
                            {
                                return new ResponseDefault<DateTime>(true, "OK", DateTime.MinValue);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                var response = new ResponseDefault<DateTime>(false, ex.Message, DateTime.Now);
                return response;
            }
        }


        public ResponseDefault<int> VerificarPlaca(string placa)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))

                {
                    connection.Open();
                    string verificaPlacaQuery = "SELECT COUNT(placa) as qtde FROM movger WHERE placa = @placa AND horasaida IS NULL";
                    using (MySqlCommand verificaPlacaCommand = new MySqlCommand(verificaPlacaQuery, connection))
                    {

                        verificaPlacaCommand.Parameters.AddWithValue("@placa", placa);
                        int veiculosComMesmaPlaca = Convert.ToInt32(verificaPlacaCommand.ExecuteScalar());

                        return new ResponseDefault<int>(true, "OK", veiculosComMesmaPlaca);
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
