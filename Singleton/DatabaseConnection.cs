using System;

namespace Singleton
{
    public class DatabaseConnection
    {
        public static TimeSpan InstantiatedTime { get; set; }
        private static DatabaseConnection dbConnection;

        private DatabaseConnection()
        {
            InstantiatedTime = DateTime.Now.TimeOfDay;
        }

        public static DatabaseConnection GetConnection()
        {            
            return dbConnection = (dbConnection ?? new DatabaseConnection());
        }
    }
}