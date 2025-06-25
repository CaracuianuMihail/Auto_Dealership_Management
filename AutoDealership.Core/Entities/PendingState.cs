using AutoDealership.Core.Entities;

namespace AutoDealership.Core.States
{
    public class PendingState : IOrderState
    {
        public void Advance(Order order)
        {
            order.State = new ApprovedState();
        }

        public string GetName() => "Pending";
    }
}
