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
        public void RegisterCustomer()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"INSERT INTO";
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
        public void RegisterOrder()
        {

        }
    }
}
