using AutoDealership.Infrastructure.Flyweights;

namespace AutoDealership.Core.Entities.CarDecorators
{
    public class BaseCar : ICar
    {
        private readonly CarContext _car;

        public BaseCar(CarContext car)
        {
            _car = car;
        }

        public string GetDescription()
        {
            return $"{_car.Flyweight.Make} {_car.Flyweight.Model} ({_car.Flyweight.Color})";
        }

        public decimal GetPrice()
        {
            return _car.Price;
        }
    }
}
