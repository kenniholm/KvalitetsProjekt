﻿using System;
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
        private string ConnectionString ="Server=EALSQL1.eal.local; Database=B_DB04_2018; User Id=B_STUDENT04; Password=B_OPENDB04;";
        public void RegisterCostumer(Customer cust)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("CUSTOMER", con);
                cmd.CommandText = @"INSERT INTO CUSTOMER (CustomerName, CustomerAddress, ZIP, Town, Telephone) VALUES (@CustomerName, @CustomerAddress, @CustomerZIP, @CustomerTOWN, @CustomerTelephone)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@CustomerName", cust.Name));
                cmd.Parameters.Add(new SqlParameter("@CustomerAddress", cust.Address));
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
            SqlCommand command = new SqlCommand("SELECT * FROM CUSTOMER WHERE CustomerId = @id", conn);
            command.Parameters.AddWithValue("@id", customerId);
            conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    string res = String.Format("{0} {1}", reader["CustomerId"], reader["CustomerName"]);
                    return res;
                }
            }
            conn.Close();
            return "Bruger findes ikke";
        }
        public void RegisterOrder(int id, string orderDate, string deliveryDate, int productId, int amount, bool picked)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ORDERS", con);
                cmd.CommandText = @"INSERT INTO ORDERS (OrderDate, DeliveryDate, Picked, CustomerId) VALUES (@OrderDate, @DeliveryDate, @Picked, @CustomerId)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@OrderDate", orderDate));
                cmd.Parameters.Add(new SqlParameter("@DeliveryDate", deliveryDate));                
                cmd.Parameters.Add(new SqlParameter("@Picked", picked));
                cmd.Parameters.Add(new SqlParameter("@CustomerId", id));
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
    }
}
