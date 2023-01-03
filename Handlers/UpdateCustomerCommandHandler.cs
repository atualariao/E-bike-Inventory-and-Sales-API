using AutoMapper;
using E_bike_Inventory_and_Sales.Commands;
using E_bike_Inventory_and_Sales.Dto.Request;
using E_bike_Inventory_and_Sales.Entity;
using E_bike_Inventory_and_Sales.Interface;
using MediatR;

namespace E_bike_Inventory_and_Sales.Handlers
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, Customer>
    {
        private readonly ICustomerRepository _customerRepository;

        public UpdateCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
        }
        public async Task<Customer> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var updateCustomer = new Customer()
            {
                Id = request.Customer.Id,
                Name = request.Customer.Name,
                Email = request.Customer.Email,
                Phone = request.Customer.Phone,
                Address = request.Customer.Address
            };

            return await _customerRepository.UpdateCustomer(updateCustomer);
        }
    }
}
