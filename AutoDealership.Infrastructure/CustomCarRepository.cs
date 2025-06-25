using System.Data.SqlClient;
using AutoDealership.Core.Entities;
using System.Configuration;

namespace AutoDealership.Infrastructure
{
    public class CustomCarRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void AddCustomCar(CustomCar car)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "INSERT INTO CustomCars (Make, Model, Year, Price, Kilometers, IsElectric, Color, InteriorType, TransmissionType, HasSunroof, WheelType, InfotainmentSystem, AdditionalNotes) " +
                            "VALUES (@Make, @Model, @Year, @Price, @Kilometers, @IsElectric, @Color, @InteriorType, @TransmissionType, @HasSunroof, @WheelType, @InfotainmentSystem, @AdditionalNotes)";
                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@Make", car.Make);
                cmd.Parameters.AddWithValue("@Model", car.Model);
                cmd.Parameters.AddWithValue("@Year", car.Year);
                cmd.Parameters.AddWithValue("@Price", car.Price);
                cmd.Parameters.AddWithValue("@Kilometers", car.Kilometers);
                cmd.Parameters.AddWithValue("@IsElectric", car.IsElectric);
                cmd.Parameters.AddWithValue("@Color", car.Color);
                cmd.Parameters.AddWithValue("@InteriorType", car.InteriorType);
                cmd.Parameters.AddWithValue("@TransmissionType", car.TransmissionType);
                cmd.Parameters.AddWithValue("@HasSunroof", car.HasSunroof);
                cmd.Parameters.AddWithValue("@WheelType", car.WheelType);
                cmd.Parameters.AddWithValue("@InfotainmentSystem", car.InfotainmentSystem);
                cmd.Parameters.AddWithValue("@AdditionalNotes", car.AdditionalNotes);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}