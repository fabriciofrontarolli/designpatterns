using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AbstractFactory
{
    public class DatabaseFactory
    {
        #region Open/Closed Properties

        Dictionary<string, Type> databaseTypes = new Dictionary<string, Type>();

        #endregion

        public DatabaseFactory()
        {
            //Get classes that implement IDatabase interface
            var dbTypesInAssembly = Assembly.GetExecutingAssembly().GetTypes()
                                                            .Where(t => t.GetInterfaces()
                                                                         .Any(i => i == typeof(IDatabase)));
            foreach (var type in dbTypesInAssembly)
            {
                databaseTypes.Add(type.Name.ToLower(), type);
            }
        }

        public IDatabase CreateInstance(string connectionName)
        {
            IDatabase databaseInstance = null;
            switch (connectionName)
            {
                case "crud":
                    databaseInstance = new SqlServerDatabase();
                    break;
                case "logging":
                    databaseInstance = new OleDBDatabase();
                    break;
                default:
                    databaseInstance = new NullDatabase();
                    break;
            }

            return databaseInstance;
        }
        
        public IDatabase CreateInstanceOCP(string connectionTypeName)
        {
            var dbType = databaseTypes[connectionTypeName];
            var dbInstance = (IDatabase)Activator.CreateInstance(dbType);
            return dbInstance;
        }
    }
}