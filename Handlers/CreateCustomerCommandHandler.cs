using E_bike_Inventory_and_Sales.Commands;
using E_bike_Inventory_and_Sales.Entity;
using E_bike_Inventory_and_Sales.Interface;
using MediatR;

namespace E_bike_Inventory_and_Sales.Handlers
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Customer>
    {
        private readonly ICustomerRepository _customerRepository;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer()
            {
                Id = request.Customer.Id,
                Name = request.Customer.Name,
                Email = request.Customer.Email,
                Phone = request.Customer.Phone,
                Address = request.Customer.Address,
            };
            return await _customerRepository.CreateCustomer(customer);
        }
    }
}
