using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;

namespace _2ApplicationLayer
{
    public class Controller
    {
        Customer customer = new Customer();
        public void CheckCustomer(int id)
        {
            customer.CheckCustomer(id);
        }
        public void RegisterCustomer()
        {

        }
    }
}
