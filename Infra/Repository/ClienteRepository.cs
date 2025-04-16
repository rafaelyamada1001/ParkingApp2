using Aplication.DTO;
using Aplication.Interface;
using Dapper;
using Domain.Entities;
using Infra.Connection;
using Infra.DataBase;

namespace Infra.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DatabaseConnection _connection;

        public ClienteRepository(DatabaseConnection connection)
        {
            _connection = connection;
        }

        public ResponseDefault<string> Cadastrar(Cliente cliente)
        {
            try
            {
                string sql = @"INSERT INTO Cliente (Nome, Sobrenome, CPF_CNPJ, Telefone) Values (@Nome, @SobreNome, @CpfCnpj, @Telefone)";

                using (var connection = _connection.OpenConnection()) { connection.Execute(sql, cliente); }

                return new ResponseDefault<string>(true, "OK", null);
            }
            catch (Exception ex)
            {
                return new ResponseDefault<string>(false, $"{ex.Message}", null);
            }
        }

        public ResponseDefault<List<Cliente>> ListarClientes()
        {
            try
            {

                string sql = "SELECT * FROM Cliente";

                using (var connection = _connection.OpenConnection())
                {
                    var response = connection.Query<Cliente>(sql).ToList();
                    return new ResponseDefault<List<Cliente>>(true, "OK", response);
                }
            }
            catch(Exception ex)
            {
                return new ResponseDefault<List<Cliente>>(false, $"{ex.Message}", null);
            }
        }

        public bool VerificarCpf(string cpf)
        {
            string sql = "SELECT COUNT(*) FROM Cliente WHERE CPF_CNPJ = @Cpf";

            using (var connection = _connection.OpenConnection())
            {
                var count = connection.ExecuteScalar<int>(sql, new { Cpf = cpf });
                return count > 0;
            }
        }
    }
}
