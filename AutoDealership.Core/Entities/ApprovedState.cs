using AutoDealership.Core.Entities;

namespace AutoDealership.Core.States
{
    public class ApprovedState : IOrderState
    {
        public void Advance(Order order)
        {
            order.State = new DeliveredState();
        }

        public string GetName() => "Approved";
    }
}
