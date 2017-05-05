using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBuilderFactoryPattern
{
    public class OleDbDatabase : Database
    {
        private DbConnection _connection = null;
        private DbCommand _command = null;

        public override DbConnection Connection
        {
            get { return _connection; }
            set { _connection = value; }
        }

        public override DbCommand Command
        {
            get
            {
                return _command;
            }
            set { _command = value; }
        }
    }
}
