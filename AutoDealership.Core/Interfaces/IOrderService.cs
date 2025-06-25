using System.Collections.Generic;
using AutoDealership.Core.Entities;

namespace AutoDealership.Core.Interfaces
{
    public interface IOrderService
    {
        void PlaceOrder(Order order);
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int id);
    }
}
