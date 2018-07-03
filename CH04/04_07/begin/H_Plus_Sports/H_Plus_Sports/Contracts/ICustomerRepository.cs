using H_Plus_Sports.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace H_Plus_Sports.Contracts
{
    public interface ICustomerRepository
    {
        Task<Customer> Add(Customer item);

        IEnumerable<Customer> GetAll();

        Task<Customer> Find(int id);

        Task<Customer> Remove(int id);

        Task<Customer> Update(Customer item);

        Task<bool> Exists(int id);
    }
}