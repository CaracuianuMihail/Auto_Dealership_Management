using System;

namespace AutoDealership.Infrastructure.Flyweights
{
    public class CarFlyweight
    {
        public string Make { get; }
        public string Model { get; }
        public string Color { get; }

        public CarFlyweight(string make, string model, string color)
        {
            Make = make;
            Model = model;
            Color = color;
        }

        public void DisplaySharedInfo()
        {
            // Opțional pentru debugging
            Console.WriteLine($"Shared Car Info: {Make} {Model} {Color}");
        }
    }
}
