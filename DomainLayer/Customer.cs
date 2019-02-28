using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Customer
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZIP { get; set; }
        public string Town { get; set; }
        public string Telephone { get; set; }

        public Customer(string name, string address, string zip, string town, string telephone)
        {
            Name = name;
            Address = address;
            ZIP = zip;
            Town = town;
            Telephone = telephone;
        }
        public Customer Register(string name, string address, string ZIP, string Town, string Telephone)
        {
            Customer cust = new Customer(name, address, ZIP, Town, Telephone);
            return cust;
        }
    }
}
