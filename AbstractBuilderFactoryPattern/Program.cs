using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBuilderFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseType dbType = DatabaseType.SqlDatabase;
            Database db = DatabaseFactory.CreateDatabase(dbType);
        }
    }
}
