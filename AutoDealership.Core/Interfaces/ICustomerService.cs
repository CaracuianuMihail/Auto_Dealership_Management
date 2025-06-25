using System.Collections.Generic;
using AutoDealership.Core.Entities;

namespace AutoDealership.Core.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
        void AddCustomer(Customer customer);
        Customer GetCustomerById(int id);
    }
}
