using AutoDealership.Core.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System;

public class CarRepository
{
    private readonly string _connectionString;

    // Constructor care citește string-ul de conexiune din App.config
    public CarRepository()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }

    // Metoda pentru a obține toate mașinile
    public List<Car> GetAllCars()
    {
        var cars = new List<Car>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Cars";
            SqlCommand cmd = new SqlCommand(query, connection);

            connection.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cars.Add(new Car
                {
                    Id = reader["Id"] != DBNull.Value ? (int)reader["Id"] : 0,  // Verifică dacă valoarea este validă
                    Make = reader["Make"].ToString(),
                    Model = reader["Model"].ToString(),
                    Color = reader["Color"].ToString(),
                    Year = reader["Year"] != DBNull.Value ? (int)reader["Year"] : 0,  // Verifică și pentru Year
                    Kilometers = reader["Kilometers"] != DBNull.Value ? (int)reader["Kilometers"] : 0,  // Verifică pentru Kilometers
                    Price = reader["Price"] != DBNull.Value ? (decimal)reader["Price"] : 0,  // Verifică și pentru Price
                    IsAvailable = reader["IsAvailable"] != DBNull.Value ? (bool)reader["IsAvailable"] : false,  // Verifică pentru IsAvailable
                    ImagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : ""
                });
            }
        }
        
        return cars;
    }


    // Metoda pentru a adăuga o mașină
    public void AddCar(Car car)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO Cars (Make, Model, Year, Price, IsAvailable, Kilometers, ImagePath) VALUES (@Make, @Model, @Year, @Price, @IsAvailable, @Kilometers, @ImagePath)";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@Make", car.Make);
            cmd.Parameters.AddWithValue("@Model", car.Model);
            cmd.Parameters.AddWithValue("@Year", car.Year);
            cmd.Parameters.AddWithValue("@Kilometers", car.Kilometers);
            cmd.Parameters.AddWithValue("@Price", car.Price);
            cmd.Parameters.AddWithValue("@IsAvailable", car.IsAvailable);
            cmd.Parameters.AddWithValue("@ImagePath", car.ImagePath ?? "");


            connection.Open();
            cmd.ExecuteNonQuery();
        }
    }


    // Metoda pentru a șterge o mașină pe baza ID-ului
    public void DeleteCar(int carId)
    {
        using (var connection = new SqlConnection(_connectionString)) // Conexiune directă la DB
        {
            string query = "DELETE FROM Cars WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@Id", carId);

            connection.Open();
            cmd.ExecuteNonQuery();
        }
    }

    // Metoda pentru a actualiza o mașină
    public void UpdateCar(Car car)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            var query = @"UPDATE Cars
                      SET Make = @Make,
                          Model = @Model,
                          Color = @Color,
                          Year = @Year,
                          Price = @Price,
                          Kilometers = @Kilometers,
                          IsAvailable = @IsAvailable,
                          ImagePath = @ImagePath
                      WHERE Id = @Id";

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Make", car.Make);
                command.Parameters.AddWithValue("@Model", car.Model);
                command.Parameters.AddWithValue("@Color", car.Color ?? "Default"); // AICI
                command.Parameters.AddWithValue("@Year", car.Year);
                command.Parameters.AddWithValue("@Price", car.Price);
                command.Parameters.AddWithValue("@Kilometers", car.Kilometers);
                command.Parameters.AddWithValue("@IsAvailable", car.IsAvailable);
                command.Parameters.AddWithValue("@ImagePath", (object)car.ImagePath ?? DBNull.Value);
                command.Parameters.AddWithValue("@Id", car.Id);

                command.ExecuteNonQuery();
            }
        }
    }

}
