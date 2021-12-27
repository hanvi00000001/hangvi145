using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace A1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            SqlConnection conn=new SqlConnection (@"Data Source=DESKTOP-VKINOHI\SQLEXPRESS;Initial Catalog=sale;User=sa; Password=000");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Customer values(5,'Nguyen Van X')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-VKINOHI\SQLEXPRESS;Initial Catalog=sale;User=sa; Password=000";
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Customer where id=2", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-VKINOHI\SQLEXPRESS;Initial Catalog=sale;User=sa; Password=000";
            conn.Open();
            SqlCommand cmd = new SqlCommand("update customer set name='Nguyen Van K' where id=5", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-VKINOHI\SQLEXPRESS;Initial Catalog=sale;User=sa; Password=000";
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dgvCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
            }
            conn.Close();
        }
    }
}
