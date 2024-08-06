using System.Data.SQLite;

namespace Ado.Data.SqlServer
{
    public class SqlConnectionFactory
    {
        public static void TestConnection(SQLiteConnection connection)
        {
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (System.Exception /*ex*/)
            {
                throw;
            }
        }

        public static SQLiteConnection GetConnection(string connectionString, bool testConnection = true)
        {
            var connection = new SQLiteConnection(connectionString);
            if(testConnection)
                TestConnection(connection);
            return connection;
        }

        public static SQLiteConnection GetConnection(ConnectionStringBuilder connectionStringBuilder)
        {
            var connection = new SQLiteConnection(connectionStringBuilder.ConnectionString);
            TestConnection(connection);
            return connection;
        }
    }
}
