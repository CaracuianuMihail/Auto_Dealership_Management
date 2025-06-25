using AutoDealership.Core.Entities;

namespace AutoDealership.Core.States
{
    public class CanceledState : IOrderState
    {
        public void Advance(Order order)
        {
            // Stare finală, nu mai avansează
        }

        public string GetName() => "Canceled";
    }
}
