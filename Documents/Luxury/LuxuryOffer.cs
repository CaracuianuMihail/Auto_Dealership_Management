using AutoDealership.Core.Entities;
using AutoDealership.Core.Interfaces;

namespace Auto_Dealership_Management.Documents.Luxury
{
    public class LuxuryOffer : IOffer
    {
        public string Generate(Car car)
        {
            return $"✨[LUXURY OFFER]✨\nCar: {car.Make} {car.Model}\nPrice: {car.Price} EUR";
        }
    }
}
