using AutoDealership.Core.Entities;
using AutoDealership.Core.Interfaces;

namespace AutoDealership.Infrastructure.Builders
{
    public class CustomCarBuilder : ICustomCarBuilder
    {
        private CustomCar _car = new CustomCar();

        public void SetMake(string make) => _car.Make = make;
        public void SetModel(string model) => _car.Model = model;
        public void SetYear(int year) => _car.Year = year;
        public void SetPrice(decimal price) => _car.Price = price;
        public void SetKilometers(int kilometers) => _car.Kilometers = kilometers;
        public void SetIsElectric(bool isElectric) => _car.IsElectric = isElectric;
        public void SetColor(string color) => _car.Color = color;
        public void SetInteriorType(string interiorType) => _car.InteriorType = interiorType;
        public void SetTransmissionType(string transmissionType) => _car.TransmissionType = transmissionType;
        public void SetHasSunroof(bool hasSunroof) => _car.HasSunroof = hasSunroof;
        public void SetWheelType(string wheelType) => _car.WheelType = wheelType;
        public void SetInfotainmentSystem(string infotainmentSystem) => _car.InfotainmentSystem = infotainmentSystem;
        public void SetAdditionalNotes(string notes) => _car.AdditionalNotes = notes;

        public CustomCar Build() => _car.Clone();  // PROTOTYPE
    }
}
