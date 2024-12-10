using MySql.Data.MySqlClient;

namespace Aplication.Interface
{

    public interface IConnection
    {
        MySqlConnection GetConnection();
    }

}
