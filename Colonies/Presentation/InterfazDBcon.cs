﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Colonies.DataAccess
{
    public interface InterfazDBcon
    {
        MySqlConnection GetConnection();
    }
}
