using AutoMapper;
using E_bike_Inventory_and_Sales.Dto.Response;
using E_bike_Inventory_and_Sales.Interface;
using E_bike_Inventory_and_Sales.Queries.CustomerQueries;
using MediatR;

namespace E_bike_Inventory_and_Sales.Handlers.QueryHandlers
{
    public class GetCustomerListQueryHandler : IRequestHandler<GetCustomerListQuery, List<CustomerDtoResponse>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetCustomerListQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<List<CustomerDtoResponse>> Handle(GetCustomerListQuery request, CancellationToken cancellationToken)
        {
            var dto = await _customerRepository.GetCustomerList();
            var customer = _mapper.Map<List<CustomerDtoResponse>>(dto);
            return customer;
        }
    }
}
