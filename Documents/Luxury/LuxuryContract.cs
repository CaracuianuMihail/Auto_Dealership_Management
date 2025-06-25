using AutoDealership.Core.Entities;
using AutoDealership.Core.Interfaces;

namespace Auto_Dealership_Management.Documents.Luxury
{
    public class LuxuryContract : IContract
    {
        public string Generate(Order order, Customer customer, Car car)
        {
            return $"✨[LUXURY CONTRACT]✨\nClient: {customer.FullName}\nCar: {car.Make} {car.Model}, {car.Year}\nOrder Date: {order.OrderDate.ToShortDateString()}";
        }
    }
}
