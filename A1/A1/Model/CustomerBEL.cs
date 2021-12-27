using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1.Model
{
    public class CustomerBEL
    {
        public int Id { get; set; }
        public AreaBEL Area { get; set; }
        public string AreaName { get { return Area.Name; } }

    }
    public class AreaBEL
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public List<CustomerBEL> Customers { get; set }
    }


}
