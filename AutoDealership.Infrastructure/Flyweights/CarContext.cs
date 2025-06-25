using System;

namespace AutoDealership.Infrastructure.Flyweights
{
    public class CarContext
    {
        public CarFlyweight Flyweight { get; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int Kilometers { get; set; }
        public bool IsAvailable { get; set; }
        public string ImagePath { get; set; }

        public CarContext(CarFlyweight flyweight, int year, decimal price, int kilometers, bool isAvailable, string imagePath)
        {
            Flyweight = flyweight;
            Year = year;
            Price = price;
            Kilometers = kilometers;
            IsAvailable = isAvailable;
            ImagePath = imagePath;
        }

        public void DisplayFullInfo()
        {
            Console.WriteLine($"Car: {Flyweight.Make} {Flyweight.Model} {Flyweight.Color}, Year: {Year}, Price: {Price}, Km: {Kilometers}, Available: {IsAvailable}");
        }
    }
}
