using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace Infra.Connection
{
    public class DatabaseConnection : IDisposable
    {
        //private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        private IDbConnection _connection;

        public DatabaseConnection()
        {
            //_configuration = configuration;
            _connectionString = "Server=localhost;Database=teste;User ID=root;Password=1234;";
        }

        public IDbConnection OpenConnection()
        {
            _connection = new MySqlConnection(_connectionString);
            _connection.Open();
            return _connection;
        }

        public void Dispose()
        {
            _connection.Close();
            _connection.Dispose();
        }
    }
}
