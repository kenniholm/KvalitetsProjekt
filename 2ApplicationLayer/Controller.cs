﻿using System;
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
        public string CheckCustomer(int id)
        {
            return customer.CheckCustomer(id);
        }
        public void RegisterCustomer(string name, string address, string zip, string town, string telephone)
        {
            customer.Register(name, address, zip, town, telephone);
        }
    }
}
