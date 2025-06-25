using System;
using System.Data.SqlClient;
using System.Configuration;

namespace AutoDealership.Infrastructure
{
    public class TestDriveRepository
    {
        private readonly string _connectionString;

        public TestDriveRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public void ScheduleTestDrive(string customerName, string carBrand, string carModel, DateTime testDriveDate, string testDriveType)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = @"
            INSERT INTO TestDriveSchedule (CustomerName, CarBrand, CarModel, TestDriveDate, TestDriveType)
            VALUES (@CustomerName, @CarBrand, @CarModel, @TestDriveDate, @TestDriveType)";

                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerName", customerName);
                command.Parameters.AddWithValue("@CarBrand", carBrand);
                command.Parameters.AddWithValue("@CarModel", carModel);
                command.Parameters.AddWithValue("@TestDriveDate", testDriveDate);
                command.Parameters.AddWithValue("@TestDriveType", testDriveType);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
