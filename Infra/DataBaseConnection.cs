namespace Infra
{
    public static class DataBaseConnection
    {
        private static string _connectionString = "Server=localhost;Database=teste;User ID=root;Password=1234;";

        public static string StringConnection()
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("Connection string não definida.");
            }

            return _connectionString;
        }

    }
}
