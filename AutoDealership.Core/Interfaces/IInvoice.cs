using AutoDealership.Core.Entities;

namespace AutoDealership.Core.Interfaces
{
    public interface IInvoice
    {
        string Generate(Order order);
    }
}