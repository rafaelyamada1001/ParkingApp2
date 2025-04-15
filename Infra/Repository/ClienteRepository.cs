using Aplication.Interface;
using Dapper;
using Domain.Entities;
using Infra.Connection;

namespace Infra.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DatabaseConnection _connection;

        public ClienteRepository(DatabaseConnection connection)
        {
            _connection = connection;
        }

        public void Cadastrar(Cliente cliente)
        {
            string sql = @"INSERT INTO Cliente (Nome, Sobrenome, CPF_CNPJ, Telefone) Values (@Nome, @SobreNome, @CpfCnpj, @Telefone)";

            using (var conn = _connection.OpenConnection()) { conn.Execute(sql, cliente); }
        }

        public bool VerificarCpf(string cpf)
        {
            string sql = "SELECT COUNT (*) FROM Cliente WHERE CPF_CNPJ = @Cpf";

            using (var conn = _connection.OpenConnection())
            {
                var count = conn.ExecuteScalar<int>(sql, new { Cpf = cpf });
                return count > 0;
            }
        }
    }
}
