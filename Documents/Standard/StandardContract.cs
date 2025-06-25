using AutoDealership.Core.Entities;
using AutoDealership.Core.Interfaces;

namespace AutoDealership.Infrastructure.Documents.Standard
{
    public class StandardContract : IContract
    {
        public string Generate(Order order, Customer customer, Car car)
        {
            return $"CONTRACT:\nClient: {customer.FullName}\nMașină: {car.Make} {car.Model} ({car.Year})\nPreț: {order.TotalPrice} EUR";
        }
    }
}