using E_bike_Inventory_and_Sales.Entity;

namespace E_bike_Inventory_and_Sales.Repository
{
    public interface ICustomerRepository
    {
        public Task<List<Customer>> GetCustomerList();
        public Task<Customer> GetSpecificCustomer(int id);
        public Task<Customer> CreateCustomer(Customer customer);
        public Task<Customer> UpdateCustomer(Customer customer);
        public Task<Customer> DeleteCustomer(int id);
    }
}
