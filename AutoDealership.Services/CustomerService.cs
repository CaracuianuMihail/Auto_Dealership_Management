using System.Collections.Generic;
using System.Linq;
using AutoDealership.Core.Entities;
using AutoDealership.Core.Interfaces;

namespace AutoDealership.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly List<Customer> _customers = new List<Customer>();

        public void AddCustomer(Customer customer) => _customers.Add(customer);

        public IEnumerable<Customer> GetAllCustomers() => _customers;

        public Customer GetCustomerById(int id) => _customers.FirstOrDefault(c => c.Id == id);
    }
}
