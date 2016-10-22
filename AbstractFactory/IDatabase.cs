using System.Data.Common;

namespace AbstractFactory
{
    public interface IDatabase
    {
        DbConnection Connection { get; set; }
        DbCommand Command { get; set; }
    }
}