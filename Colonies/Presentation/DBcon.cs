using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Colonies.DataAccess
{
    public class DBcon : InterfazDBcon
    {
        private static DBcon _instance;
        private MySqlConnection _connection;

        private DBcon()
        {
            _connection = new MySqlConnection("Server=localhost;Port=3306;Database=comarcas_xupi;User ID=root; Password=1234;");
        }

        public static DBcon Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DBcon();
                }
                return _instance;
            }
        }
        public MySqlConnection GetConnection()
        {
            return _connection;
        }
    }

}
