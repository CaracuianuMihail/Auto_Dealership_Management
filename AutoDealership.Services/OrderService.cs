using System;
using System.Collections.Generic;
using System.Linq;
using AutoDealership.Core.Entities;
using AutoDealership.Core.Interfaces;

namespace AutoDealership.Services
{
    public class OrderService : IOrderService
    {
        private readonly List<Order> _orders = new List<Order>();

        public void PlaceOrder(Order order)
        {
            order.OrderDate = DateTime.Now;
            _orders.Add(order);
        }

        public IEnumerable<Order> GetAllOrders() => _orders;

        public Order GetOrderById(int id) => _orders.FirstOrDefault(o => o.Id == id);
    }
}
