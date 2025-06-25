using AutoDealership.Core.Entities;

namespace AutoDealership.Core.Interfaces
{
    public interface IContract
    {
        string Generate(Order order, Customer customer, Car car);
    }
}