using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBuilderFactoryPattern
{
    public class SqlDatabaseBuilder: IDatabaseBuilder
    {
        private Database _database;
        public Database Database { get { return _database; }  }

        public SqlDatabaseBuilder()
        {
            _database = new SqlDatabase();
        }
        public void BuildConnection()
        {
            _database.Connection = new SqlConnection();
        }

        public void BuildCommand()
        {
            _database.Command = new SqlCommand();
        }
    }
}
