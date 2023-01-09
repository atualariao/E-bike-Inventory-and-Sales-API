using E_bike_Inventory_and_Sales.Commands.CustomerCommands;
using E_bike_Inventory_and_Sales.Data;
using E_bike_Inventory_and_Sales.Repository;
using MediatR;

namespace E_bike_Inventory_and_Sales.Handlers.CommandHandlers
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, Customer>
    {
        private readonly ICustomerRepository _customerRepository;

        public DeleteCustomerCommandHandler(ICustomerRepository customerRepository) => _customerRepository = customerRepository;

        public async Task<Customer> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            return await _customerRepository.DeleteCustomer(request.id);
        }
    }
}
