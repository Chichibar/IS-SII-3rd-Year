
using System.Data.SqlClient;

namespace juarenact1
{
    internal class Db
    {
        private static readonly string productConnection =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=actmaamjodb;Integrated Security=True";

        private static readonly string userConnection =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=logindb;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(productConnection);
        }

        public static SqlConnection GetUserConnection()
        {
            return new SqlConnection(userConnection);
        }
    }
}
