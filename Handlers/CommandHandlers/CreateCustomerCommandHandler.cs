using AutoMapper;
using E_bike_Inventory_and_Sales.Commands.CustomerCommands;
using E_bike_Inventory_and_Sales.Data;
using E_bike_Inventory_and_Sales.Dto.Request;
using E_bike_Inventory_and_Sales.Repository;
using MediatR;

namespace E_bike_Inventory_and_Sales.Handlers
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Customer>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<Customer> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customerDto = new CustomerDtoRequest()
            {
                Name = request.Customer.Name,
                Email = request.Customer.Email,
                Phone = request.Customer.Phone,
                Address = request.Customer.Address,
            };

            Customer customer = _mapper.Map<Customer>(customerDto);
            return await _customerRepository.CreateCustomer(customer);
        }
    }
}
