using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DomainLayer
{
    public class Customer
    {
        string Id { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        string ZIP { get; set; }
        string Town { get; set; }
        string Telephone { get; set; }

        DBcontroller dbConn = new DBcontroller();
        public string CheckCustomer(int id)
        {            
            return dbConn.CheckCustomer(id);
        }
    }   
}
