using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using AutoDealership.Core.Entities;

namespace AutoDealership.Infrastructure
{
    public class CustomerRepository
    {
        private readonly string _connectionString;

        // Constructor care citește string-ul de conexiune din App.config
        public CustomerRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public void AddCustomer(Customer customer)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "INSERT INTO Customers (FullName, Email, PhoneNumber) VALUES (@FullName, @Email, @Phone)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FullName", customer.FullName);
                command.Parameters.AddWithValue("@Email", customer.Email);
                command.Parameters.AddWithValue("@Phone", customer.PhoneNumber);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Customer> GetAllCustomers()
        {
            var list = new List<Customer>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "SELECT * FROM Customers";
                var command = new SqlCommand(query, connection);
                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Customer
                    {
                        Id = (int)reader["Id"],
                        FullName = reader["FullName"].ToString(),
                        Email = reader["Email"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString()
                    });
                }
            }
            return list;
        }
    }
}
