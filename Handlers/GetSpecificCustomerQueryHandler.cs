using E_bike_Inventory_and_Sales.Entity;
using E_bike_Inventory_and_Sales.Interface;
using E_bike_Inventory_and_Sales.Queries;
using MediatR;

namespace E_bike_Inventory_and_Sales.Handlers
{
    public class GetSpecificCustomerQueryHandler : IRequestHandler<GetSpecificCustomerQuery, Customer>
    {
        private readonly ICustomerRepository _customerRepository;

        public GetSpecificCustomerQueryHandler(ICustomerRepository customerRepository) => _customerRepository = customerRepository;

        public async Task<Customer> Handle(GetSpecificCustomerQuery request, CancellationToken cancellationToken)
        {
            return await _customerRepository.GetSpecificCustomer(request.id);
        }
    }
}
