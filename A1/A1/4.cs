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
    public partial class _4 : Form
    {
        customerBAL cusBAL = new customerBAL();
        public _4()
        {
            InitializeComponent();
        }

        private void _4_Load(object sender, EventArgs e)
        {
            List<customerBEL> lstCus = (List<customerBEL>)cusBAL.ReadCustomer();
            foreach
                (
                customerBEL cus in lstCus)
            {
                dgvCustomer.Rows.Add(cus.Id, cus.Name);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            customerBEL cus = new customerBEL();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;

            cusBAL.NewCustomer(cus);
            dgvCustomer.Rows.Add(cus.Id, cus.Name);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            customerBEL cus = new customerBEL();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;

            cusBAL.DeleteCustomer(cus);
            int idx = dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows.RemoveAt(idx);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            customerBEL cus = new customerBEL();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;

            cusBAL.EditCustomer(cus);
            DataGridViewRow row = dgvCustomer.CurrentRow; 
            row.Cells[0].Value = cus.Id;
            row.Cells[1].Value = cus.Name;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
