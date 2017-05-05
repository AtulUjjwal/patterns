using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBuilderFactoryPattern
{
    public class DatabaseFactory
    {
        public static Database CreateDatabase(DatabaseType dbType)
        {
            IDatabaseBuilder dbBuilder;
            switch (dbType)
            {
                case DatabaseType.SqlDatabase:
                    dbBuilder = new SqlDatabaseBuilder();
                    break;
                case DatabaseType.OleDbdatabase:
                default:
                    dbBuilder = new OleDbBuilder();
                    break;
            }
            DatabaseDirector dbDirector = new DatabaseDirector();
            dbDirector.Build(dbBuilder);
            return dbBuilder.Database;
        }
    }
}
