using Aplication.DTO;
using Aplication.Interface;
using MySql.Data.MySqlClient;


namespace Infra.Repository
{
    public class EstacionamentoRepository : IEstacionamentoRepository
    {
        private readonly MySqlConnection _connection;

        public EstacionamentoRepository(IConnection connection)
        {
            _connection = connection.GetConnection();
        }

        public ResponseDefault<VagasTotaisDTO> VagasTotais()
        {
            var vagasTotaisCarros = 0;
            var vagasTotaisMotos = 0;
            decimal valorHora = 0;

            try
            {
                string query = "SELECT TotalVagasCarros, TotalVagasMotos, ValorHora FROM estacionamento";

                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            valorHora = reader.GetDecimal("ValorHora");
                            vagasTotaisCarros = reader.GetInt32("TotalVagasCarros");
                            vagasTotaisMotos = reader.GetInt32("TotalVagasMotos");

                        }
                        else
                        {
                            Console.WriteLine("Nenhum registro encontrado.");
                        }
                    }
                }

                var dto = new VagasTotaisDTO(vagasTotaisCarros, vagasTotaisMotos, valorHora);

                var response = new ResponseDefault<VagasTotaisDTO>(true, "OK", dto);
                return response;
            }
            catch (Exception ex)
            {
                var response = new ResponseDefault<VagasTotaisDTO>(false, ex.Message, null);
                return response;
            }
        }

        public ResponseDefault<TipoVagasDTO> VagasOcupadas()
        {
            try
            {
                string query = @"SELECT TipoVeiculo, COUNT(placa) AS qtde FROM movger WHERE horasaida IS NULL GROUP BY TipoVeiculo";

                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        int vagasOcupadasCarros = 0;
                        int vagasOcupadasMotos = 0;

                        while (reader.Read())
                        {
                            string tipoVeiculo = reader.GetString("TipoVeiculo");
                            int qtde = reader.GetInt32("qtde");

                            if (tipoVeiculo == "Carro")
                                vagasOcupadasCarros = qtde;
                            else if (tipoVeiculo == "Moto")
                                vagasOcupadasMotos = qtde;
                        }

                        var dto = new TipoVagasDTO(vagasOcupadasCarros, vagasOcupadasMotos);
                        return new ResponseDefault<TipoVagasDTO>(true, "OK", dto);
                    }
                }
            }
            catch (Exception ex)
            {
                return new ResponseDefault<TipoVagasDTO>(false, ex.Message, null);
            }
        }
    }
}
