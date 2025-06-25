using AutoDealership.Core.Entities;
using AutoDealership.Core.Interfaces;

namespace AutoDealership.Infrastructure.Documents.Standard
{
    public class StandardOffer : IOffer
    {
        public string Generate(Car car)
        {
            return $"OFERTĂ:\nMașină: {car.Make} {car.Model} ({car.Year})\nPreț: {car.Price} EUR\nDisponibil: {(car.IsAvailable ? "DA" : "NU")}";
        }
    }
}