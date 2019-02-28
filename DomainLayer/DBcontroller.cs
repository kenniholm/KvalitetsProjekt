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
        public string CheckCustomer(int customerId)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string sql = "SELECT * FROM Customer WHERE CustomerID=@id";
            SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE CustomerID = @id", conn);
            command.Parameters.AddWithValue("@id", customerId);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return String.Format("{0}", reader["id"]);
                }
            }
            conn.Close();
            throw new Exception("der findes ikke en bruger med det id");
        }
        public void RegisterOrder(Order order)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"INSERT INTO ORDERS (Customer, OrderId, OrderDate, DeliveryDate, Picked) VALUES (@Customer, @OrderId, @OrderDate, @DeliveryDate, @Picked)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Customer", order.Id));
                cmd.Parameters.Add(new SqlParameter("@OrderId", order.OrderDate));
                cmd.Parameters.Add(new SqlParameter("@OrderDate", order.OrderDate));
                cmd.Parameters.Add(new SqlParameter("@DeliveryDate", order.DeliveryDate));
                cmd.Parameters.Add(new SqlParameter("@Picked", order.Picked));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
