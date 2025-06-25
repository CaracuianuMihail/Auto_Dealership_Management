using AutoDealership.Core.Entities;

namespace AutoDealership.Core
{
    public interface IOrderState
    {
        void Advance(Order order);
        string GetName();
    }
}
