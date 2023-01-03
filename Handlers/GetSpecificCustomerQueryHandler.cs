using AutoMapper;
using E_bike_Inventory_and_Sales.Dto.Request;
using E_bike_Inventory_and_Sales.Dto.Response;
using E_bike_Inventory_and_Sales.Entity;
using E_bike_Inventory_and_Sales.Interface;
using E_bike_Inventory_and_Sales.Queries;
using MediatR;

namespace E_bike_Inventory_and_Sales.Handlers
{
    public class GetSpecificCustomerQueryHandler : IRequestHandler<GetSpecificCustomerQuery, CustomerDtoResponse>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetSpecificCustomerQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<CustomerDtoResponse> Handle(GetSpecificCustomerQuery request, CancellationToken cancellationToken)
        {
            var id = await _customerRepository.GetSpecificCustomer(request.id);
            var dto = _mapper.Map<CustomerDtoResponse>(id);
            return dto;
        }
    }
}
