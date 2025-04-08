using Aplication.DTO;
using Aplication.Interface;
using Dapper;
using Infra.Connection;

namespace Infra.Repository
{
    public class EstacionamentoRepository : IEstacionamentoRepository
    {        
        private readonly DatabaseConnection _connection;

        public EstacionamentoRepository(DatabaseConnection connection)
        {
            _connection = connection;
        }

        public ResponseDefault<VagasTotaisDTO> VagasTotais()
        {
            try
            {
                string query = "SELECT TotalVagasCarros, TotalVagasMotos, ValorHora FROM estacionamento";

                using (var connection = _connection.OpenConnection())
                {
                    var vagasTotais = connection.QueryFirstOrDefault<VagasTotaisDTO>(query);
                    if (vagasTotais != null)
                        return new ResponseDefault<VagasTotaisDTO>(true, "OK", vagasTotais);
                    else
                        return new ResponseDefault<VagasTotaisDTO>(false, "Nenhum registro encontrado.", null);
                }
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

                using (var connection = _connection.OpenConnection())
                {
                    var vagas = connection.Query<(string TipoVeiculo, int qtde)>(query).ToList();

                    int vagasOcupadasCarros = 0;
                    int vagasOcupadasMotos = 0;

                    foreach (var vaga in vagas)
                    {
                        if (vaga.TipoVeiculo == "Carro")
                            vagasOcupadasCarros = vaga.qtde;
                        if(vaga.TipoVeiculo == "Moto")
                            vagasOcupadasMotos = vaga.qtde;
                    }

                    var dto = new TipoVagasDTO(vagasOcupadasCarros, vagasOcupadasMotos);
                    return new ResponseDefault<TipoVagasDTO>(true, "OK", dto);

                }
            }
            catch (Exception ex)
            {
                return new ResponseDefault<TipoVagasDTO>(false, ex.Message, null);
            }
        }
    }
}
