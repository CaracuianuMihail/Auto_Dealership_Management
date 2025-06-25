using AutoDealership.Core.Entities;
using AutoDealership.Core.Interfaces;

namespace Auto_Dealership_Management.Documents.Luxury
{
    public class LuxuryInvoice : IInvoice
    {
        public string Generate(Order order)
        {
            return $"✨[LUXURY INVOICE]✨\nOrder ID: {order.Id}\nAmount: {order.TotalPrice} EUR";
        }
    }
}
