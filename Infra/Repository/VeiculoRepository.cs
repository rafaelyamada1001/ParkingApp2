using Aplication.DTO;
using Aplication.Interface;
using Dapper;
using Domain.Entities;
using Infra.Connection;
using MySql.Data.MySqlClient;


namespace Infra.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {

        private readonly DatabaseConnection _connection;

        public VeiculoRepository(DatabaseConnection connection)
        {
  
            _connection = connection;
        }

        public ResponseDefault<bool> AdicionarVeiculo(Veiculos veiculo)
        {
            try
            {
                string insertQuery = "INSERT INTO MovGer (Placa, TipoVeiculo, HoraEntrada) VALUES (@Placa, @TipoVeiculo, @HoraEntrada)";

                var parametros = new
                {
                    Placa = veiculo.Placa.Placa,
                    TipoVeiculo = veiculo.TipoVeiculo.ToString(),
                    HoraEntrada = veiculo.HoraEntrada
                };

                using (var connection = _connection.OpenConnection())
                {
                    var result = connection.Execute(insertQuery, parametros);
                }

                return new ResponseDefault<bool>(true, "Veículo adicionado com sucesso", true);
            }
            catch (Exception ex)
            {
                return new ResponseDefault<bool>(false, ex.Message, false);
            }
        }

        public ResponseDefault<List<VeiculosDTO>> ListarVeiculos()
        {
            try
            {
                string query = "SELECT placa, TipoVeiculo, HoraEntrada FROM movger WHERE horasaida is null";

                using (var connection = _connection.OpenConnection())
                {
                    var veiculos = connection.Query<VeiculosDTO>(query).ToList();

                    if (veiculos.Any())
                    {
                        return new ResponseDefault<List<VeiculosDTO>>(true, "OK", veiculos);
                    }
                    else
                    {
                        return new ResponseDefault<List<VeiculosDTO>>(false, "Nenhum Veículo Encontrado!", null);
                    }
                }
            }
            catch (Exception ex)
            {
                var response = new ResponseDefault<List<VeiculosDTO>>(false, ex.Message, null);
                return response;
            }
        }

        public ResponseDefault<bool> RemoverVeiculo(string placa, DateTime horaSaida, double horasEstacionadas, double minutosEstacionados, decimal valor)
        {
            try
            {
                string updateQuery =
                    "UPDATE MovGer SET HoraSaida = @HoraSaida, PermanenciaHora = @PermanenciaHora, PermanenciaMin = @PermanenciaMin, Valor = @Valor " +
                    "WHERE Placa = @Placa AND HoraSaida IS NULL";

                var parametros = new
                {
                    Placa = placa,
                    HoraSaida = horaSaida,
                    PermanenciaHora = Math.Floor(horasEstacionadas),
                    PermanenciaMin = minutosEstacionados,
                    Valor = valor
                };
                using (var connection = _connection.OpenConnection())
                {
                    var updateRows = connection.Execute(updateQuery, parametros);
                    if (updateRows > 0) return new ResponseDefault<bool>(true, "OK", true);
                    else return new ResponseDefault<bool>(false, "Veículo não encontrado", false);

                }
            }
            catch (Exception ex)
            {
                return new ResponseDefault<bool>(false, ex.Message, false);
            }
        }

        public ResponseDefault<DateTime> VerificarPermanencia(string placa)
        {
            try
            {
                string query = "SELECT HoraEntrada FROM movger WHERE placa = @Placa and HoraSaida is null";

                var parametros = new { Placa = placa };

                using (var connection = _connection.OpenConnection())
                {
                    var horaEntrada = connection.QueryFirstOrDefault<DateTime?>(query, parametros);
                    if (horaEntrada.HasValue)
                    {
                        return new ResponseDefault<DateTime>(true, "OK", horaEntrada.Value);
                    }
                    else
                    {
                        return new ResponseDefault<DateTime>(true, "OK", DateTime.MinValue);
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
                var parametros = new { Placa = placa };

                string query = "SELECT COUNT(placa) as qtde FROM movger WHERE placa = @placa AND horasaida IS NULL";
                using (var connection = _connection.OpenConnection())
                {
                    var veiculosComMesmaPlaca = connection.ExecuteScalar<int>(query, parametros);

                    return new ResponseDefault<int>(true, "OK", veiculosComMesmaPlaca);
                }

            }
            catch (Exception ex)
            {
                var response = new ResponseDefault<int>(false, ex.Message, 0);
                return response;
            }
        }

        public ResponseDefault<string> TipoVeiculo(string placa)
        {
            try
            {
                //var parametros = new { Placa = placa };

                string query = "SELECT TipoVeiculo FROM MOVGER WHERE Placa = @Placa AND horasaida IS NULL";

                using (var connection = _connection.OpenConnection())
                {
                    var tipoVeiculo = connection.QueryFirstOrDefault<string>(query, new { Placa = placa });

                    return new ResponseDefault<string>(true, "OK", tipoVeiculo);

                }
            }
            catch (Exception ex)
            {
                return new ResponseDefault<string>(false, ex.Message, null);
            }
        }

        public ResponseDefault<bool> EditarVeiculo(string placaAtual, string placaNova, string tipoVeiculo)
        {
            try
            {
                string query = "UPDATE movger SET Placa = @PlacaNova, TipoVeiculo = @TipoVeiculo " +
                "WHERE Placa = @PlacaAtual AND horasaida IS NULL";

                var parametros = new
                {
                    PlacaAtual = placaAtual,
                    PlacaNova = placaNova,
                    TipoVeiculo = tipoVeiculo,
                };
                using (var connection = _connection.OpenConnection())
                {
                    var updateRows = connection.Execute(query, parametros);
                    if (updateRows > 0) return new ResponseDefault<bool>(true, "OK", true);
                    else return new ResponseDefault<bool>(false, "Erro", false);
                }

            }catch(Exception ex) 
            {
                return new ResponseDefault<bool>(false, ex.Message, false);
            }
        }
    }
}



