using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace A1
{
    class customerBAL
    {
        customerDAL dal = new customerDAL();
        public IList<customerBEL> ReadCustomer()
        {
            List<customerBEL> lstCus = dal.ReadCustomer();
            return lstCus;
        }
        public void NewCustomer (customerBEL cus)
        {
            dal.NewCustomer(cus);
           
        }
        public void DeleteCustomer(customerBEL cus)
        {
            dal.DeleteCustomer(cus);

        }
        public void EditCustomer(customerBEL cus)
        {
            dal.EditCustomer(cus);
        }

    }
}
