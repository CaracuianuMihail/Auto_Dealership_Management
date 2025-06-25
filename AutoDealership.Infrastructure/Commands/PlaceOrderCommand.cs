using AutoDealership.Core.Entities;
using AutoDealership.Core.Interfaces;
using AutoDealership.Infrastructure;

namespace AutoDealership.Core.Commands
{
    public class PlaceOrderCommand : ICommand
    {
        private readonly OrderRepository _repository;
        private readonly Order _order;

        public PlaceOrderCommand(OrderRepository repository, Order order)
        {
            _repository = repository;
            _order = order;
        }

        public void Execute()
        {
            _repository.PlaceOrder(_order);
        }
    }
}
