using System.Data.Common;

namespace AbstractFactory
{
    public class NullDatabase : IDatabase
    {
        private DbCommand command = null;
        private DbConnection connection = null;

        public DbCommand Command
        {
            get
            {
                if (command == null)
                {
                    command = new OleDbCommand();
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
                if (connection == null)
                {
                    var connectionString = ConfigurationManager.ConnectionStrings["OleDBConnectionString"].ConnectionString;
                    connection = new OleDbConnection(connectionString);
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