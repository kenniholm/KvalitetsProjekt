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
        public void RegisterCostumer(Customer cust)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"INSERT INTO Customer (CustomerName, CustomerAddress, CustomerZIP, CustomerTOWN, CustomerTelephone) VALUES (@CustomerName, @CustomerAddress, @CustomerZIP, @CustomerTOWN, @CustomerTelephone)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@CustomerName", cust.Name));
                cmd.Parameters.Add(new SqlParameter("@CustomeAddress", cust.Address));
                cmd.Parameters.Add(new SqlParameter("@CustomerZIP", cust.ZIP));
                cmd.Parameters.Add(new SqlParameter("@CustomerTOWN", cust.Town));
                cmd.Parameters.Add(new SqlParameter("@CustomerTelephone", cust.Telephone));
                cmd.ExecuteNonQuery();
                con.Close();
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
