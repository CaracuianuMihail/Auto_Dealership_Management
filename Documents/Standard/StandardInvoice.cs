using AutoDealership.Core.Entities;
using AutoDealership.Core.Interfaces;

namespace AutoDealership.Infrastructure.Documents.Standard
{
    public class StandardInvoice : IInvoice
    {
        public string Generate(Order order)
        {
            return $"FACTURĂ:\nOrder ID: {order.Id}\nData: {order.OrderDate.ToShortDateString()}\nTotal: {order.TotalPrice} EUR";
        }
    }
}