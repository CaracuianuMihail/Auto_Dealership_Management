using AutoDealership.Core.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace AutoDealership.Infrastructure
{
    public class OrderRepository
    {
        private readonly string _connectionString;

        // Constructor care citește string-ul de conexiune din App.config
        public OrderRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public void PlaceOrder(Order order)
        {
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand(
                        "INSERT INTO Orders (CustomerId, CarId, TotalPrice, OrderDate, DiscountType, OrderState) " +
                        "VALUES (@CustomerId, @CarId, @TotalPrice, @OrderDate, @DiscountType, @OrderState)", connection);

                    command.Parameters.AddWithValue("@OrderState", order.OrderState);
                    command.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                    command.Parameters.AddWithValue("@CarId", order.CarId);
                    command.Parameters.AddWithValue("@TotalPrice", order.TotalPrice);
                    command.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                    command.Parameters.AddWithValue("@DiscountType", order.DiscountType ?? "Nespecificat");

                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteOrder(int orderId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM Orders WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", orderId);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateOrderState(int orderId, string newState)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Orders SET OrderState = @State WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@State", newState);
                command.Parameters.AddWithValue("@Id", orderId);
                command.ExecuteNonQuery();
            }
        }
        public List<Order> GetAllOrders()
        {
            var list = new List<Order>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "SELECT * FROM Orders";
                var command = new SqlCommand(query, connection);
                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Order
                    {
                        Id = (int)reader["Id"],
                        CarId = (int)reader["CarId"],
                        CustomerId = (int)reader["CustomerId"],
                        OrderDate = (DateTime)reader["OrderDate"],
                        TotalPrice = (decimal)reader["TotalPrice"],
                        DiscountType = reader["DiscountType"].ToString(),
                        OrderState = reader["OrderState"].ToString()
                    });
                }
            }
            return list;
        }
    }
}
