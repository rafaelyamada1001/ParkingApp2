using Aplication.Interface;
using MySql.Data.MySqlClient;


namespace Infra.DataBase
{
    public sealed class Connection : IConnection
    {

        private readonly MySqlConnection _instance;

        public Connection()
        {
            _instance = CreateConnection();
        }

        public MySqlConnection GetConnection()
        {
            return _instance;
        }

        private static MySqlConnection CreateConnection()
        {
            var connection = new MySqlConnection("Server=localhost;Database=teste;User ID=root;Password=1234;");
            connection.Open();
            return connection;
        }
    }
}