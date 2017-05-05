using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBuilderFactoryPattern
{
    public class OleDbBuilder: IDatabaseBuilder
    {
        private Database _database;
        public Database Database { get { return _database; }  }

        public OleDbBuilder()
        {
            _database = new OleDbDatabase();
        }
        public void BuildConnection()
        {
            _database.Connection = new OleDbConnection();
        }

        public void BuildCommand()
        {
            _database.Command = new OleDbCommand();
        }
    }
}
