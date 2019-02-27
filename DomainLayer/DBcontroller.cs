using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DomainLayer
{
    public class DBcontroller
    {
        private string ConnectionString ="Server=EALSQL1.eal.local; Database= B_DB04_2018; User Id=B_STUDENT04; Password=B_OPENDB04;";
        public void RegisterCostumer()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"INSERT INTO";
            }
        }
        public bool CheckCustomer()
        {
            return true;
        }
        public void RegisterOrder()
        {

        }
    }
}
