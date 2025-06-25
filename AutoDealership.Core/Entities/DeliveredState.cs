using AutoDealership.Core.Entities;

namespace AutoDealership.Core.States
{
    public class DeliveredState : IOrderState
    {
        public void Advance(Order order)
        {
        
        }

        public string GetName() => "Delivered";
    }
}
