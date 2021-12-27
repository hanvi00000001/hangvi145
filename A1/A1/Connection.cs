using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace A1
{
    class Connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-VKINOHI\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";
        public SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }

    }
}
