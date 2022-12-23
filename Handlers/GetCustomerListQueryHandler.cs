using E_bike_Inventory_and_Sales.Entity;
using E_bike_Inventory_and_Sales.Interface;
using E_bike_Inventory_and_Sales.Queries;
using MediatR;

namespace E_bike_Inventory_and_Sales.Handlers
{
    public class GetCustomerListQueryHandler : IRequestHandler<GetCustomerListQuery, List<Customer>>
    {
        private readonly ICustomerRepository _customerRepository;

        public GetCustomerListQueryHandler(ICustomerRepository customerRepository) => _customerRepository = customerRepository;

        public async Task<List<Customer>> Handle(GetCustomerListQuery request, CancellationToken cancellationToken)
        {
            return await _customerRepository.GetCustomerList();
        }
    }
}
