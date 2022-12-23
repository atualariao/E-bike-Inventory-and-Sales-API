using Dapper;
using E_bike_Inventory_and_Sales.Data;
using E_bike_Inventory_and_Sales.Entity;
using E_bike_Inventory_and_Sales.Interface;
using Microsoft.EntityFrameworkCore;

namespace E_bike_Inventory_and_Sales.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly MyDbContext _context;

        public CustomerRepository(MyDbContext context) => _context = context;

        public async Task<List<Customer>> GetCustomerList()
        {
            var query = "SELECT * FROM Customers";
            try
            {
                using (var connection = _context.Database.GetDbConnection())
                {
                    var customerList = await connection.QueryAsync<Customer>(query);
                    return customerList.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Customer> GetSpecificCustomer(int id)
        {
            var query = "SELECT * FROM Customers WHERE Id = @id";

            try
            {
                using (var connection = _context.Database.GetDbConnection())
                {
                    var customer = await connection.QuerySingleOrDefaultAsync<Customer>(query, new { id });

                    return customer;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            try
            {
                var newCustomer = new Customer()
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Email = customer.Email,
                    Phone = customer.Phone,
                    Address = customer.Address,
                    Debt = customer.Debt,
                    Sales = customer.Sales,
                };

                _context.Add(newCustomer);
                await _context.SaveChangesAsync();

                return newCustomer;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            try
            {
                var updateCustomer = await _context.Customers.FindAsync(customer.Id);
                updateCustomer.Name = customer.Name;
                updateCustomer.Email = customer.Email;
                updateCustomer.Phone = customer.Phone;
                updateCustomer.Address = customer.Address;

                _context.Customers.Update(updateCustomer);
                await _context.SaveChangesAsync();

                return customer;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            try
            {
                var customer = _context.Customers.Find(id);

                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();

                return customer;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
