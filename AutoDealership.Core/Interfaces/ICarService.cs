using System.Collections.Generic;
using AutoDealership.Core.Entities;

namespace AutoDealership.Core.Interfaces
{
    public interface ICarService
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int id);
        void AddCar(Car car);
        void RemoveCar(int id);
        void UpdateCar(Car car);
    }
}
