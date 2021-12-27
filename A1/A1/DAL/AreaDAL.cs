using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace A1.DAL
{
    public class AreaDAL: BConnection
    {
        public List<AreaBEL> ReadAreaList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select *from Areas", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<AreaBEL> lstArea = new List<AreaBEL>();
            while (reader.Read())
            {

            }
        }
    }
}
