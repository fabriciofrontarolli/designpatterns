using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace AbstractFactory
{
    public class SqlServerDatabase : IDatabase
    {
        private DbConnection connection = null;
        private DbCommand command = null;

        public DbCommand Command
        {
            get
            {
                if (command == null)
                {
                    command = new SqlCommand();
                    command.Connection = connection;
                }
                return command;
            }

            set
            {
                command = value;
            }
        }

        public DbConnection Connection
        {
            get
            {
                // Lazy Loading...
                if (connection == null)
                {
                    var connectionString = ConfigurationManager.ConnectionStrings["SQLServerConnectionString"].ConnectionString;
                    connection = new SqlConnection(connectionString);
                }
                return connection;
            }

            set
            {
                connection = value;
            }
        }
    }
}