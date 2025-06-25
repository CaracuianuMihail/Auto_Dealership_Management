using System.Collections.Generic;
using System.Linq;
using AutoDealership.Core.Entities; // pentru clasa Car din DB
using AutoDealership.Infrastructure.Flyweights;

namespace AutoDealership.Services
{
    public class CarService
    {
        private readonly List<CarContext> _cars = new List<CarContext>();
        private readonly CarFlyweightFactory _flyweightFactory = new CarFlyweightFactory();

        public void AddCar(string make, string model, string color, int year, decimal price, int kilometers, bool isAvailable, string imagePath)
        {
            var flyweight = _flyweightFactory.GetFlyweight(make, model, color);
            var carContext = new CarContext(flyweight, year, price, kilometers, isAvailable, imagePath);
            _cars.Add(carContext);
        }

        public IEnumerable<CarContext> GetAllCars() => _cars;

        public CarContext GetCarByIndex(int index) =>
            (index >= 0 && index < _cars.Count) ? _cars[index] : null;

        public void RemoveCarByIndex(int index)
        {
            if (index >= 0 && index < _cars.Count)
                _cars.RemoveAt(index);
        }

        public void UpdateCar(int index, int year, decimal price, int kilometers, bool isAvailable, string imagePath)
        {
            var existing = GetCarByIndex(index);
            if (existing != null)
            {
                existing.Year = year;
                existing.Price = price;
                existing.Kilometers = kilometers;
                existing.IsAvailable = isAvailable;
                existing.ImagePath = imagePath;
            }
        }

        public void LoadFromDb(List<Car> carsFromDb)
        {
            foreach (var car in carsFromDb)
            {
                var flyweight = _flyweightFactory.GetFlyweight(car.Make, car.Model, car.Color);
                var context = new CarContext(flyweight, car.Year, car.Price, car.Kilometers, car.IsAvailable, car.ImagePath);
                _cars.Add(context);
            }
        }

        public int FlyweightCount => _flyweightFactory.Count;
    }
}
