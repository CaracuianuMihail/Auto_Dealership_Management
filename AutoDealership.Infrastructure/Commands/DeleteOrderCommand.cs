using AutoDealership.Core.Entities;
using AutoDealership.Core.Interfaces;
using AutoDealership.Infrastructure;

namespace AutoDealership.Core.Commands
{
    public class DeleteOrderCommand : ICommand
    {
        private readonly OrderRepository _repository;
        private readonly int _orderId;

        public DeleteOrderCommand(OrderRepository repository, int orderId)
        {
            _repository = repository;
            _orderId = orderId;
        }

        public void Execute()
        {
            _repository.DeleteOrder(_orderId);
        }
    }
}
