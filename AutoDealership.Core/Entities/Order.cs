using AutoDealership.Core.States;
using System;

namespace AutoDealership.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public string DiscountType { get; set; }

        // Obiectul real al stării curente
        public IOrderState State { get; set; } = new PendingState();

        // Proprietate auxiliară pentru salvare/încărcare în DB
        public string OrderState
        {
            get => GetStateName();
            set
            {
                switch (value)
                {
                    case "Approved":
                        State = new ApprovedState();
                        break;
                    case "Delivered":
                        State = new DeliveredState();
                        break;
                    case "Canceled":
                        State = new CanceledState();
                        break;
                    default:
                        State = new PendingState();
                        break;
                }
            }
        }


        // Avansare în următoarea stare
        public void AdvanceState()
        {
            State.Advance(this);
        }

        public string GetStateName()
        {
            return State.GetName();
        }
    }
}
