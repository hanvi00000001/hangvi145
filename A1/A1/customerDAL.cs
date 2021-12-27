using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace A1
{
    public class customerDAL : DBConnection
    {
        public List<customerBEL> ReadCustomer()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<customerBEL> lstCus = new List<customerBEL>();
            while (reader.Read())
            {
                customerBEL cus = new customerBEL();
                cus.Id = int.Parse(reader["id"].ToString());
                cus.Name = reader["name"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
        public void DeleteCustomer(customerBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Customer where id=@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void NewCustomer(customerBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Customer values(@id,@name)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void EditCustomer(customerBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update customer set Name =@name where id=@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
