using AutoMapper;
using E_bike_Inventory_and_Sales.Dto.Response;
using E_bike_Inventory_and_Sales.Interface;
using E_bike_Inventory_and_Sales.Queries.DebtQueries;
using MediatR;

namespace E_bike_Inventory_and_Sales.Handlers.QueryHandlers
{
    public class GetSpecificDebtQueryHandler : IRequestHandler<GetSpecificDebtQuery, DebtDtoResponse>
    {
        private readonly IDebtRepository _debtRepository;
        private readonly IMapper _mapper;

        public GetSpecificDebtQueryHandler(IDebtRepository debtRepository, IMapper mapper)
        {
            _mapper = mapper;
            _debtRepository = debtRepository;
        }

        public async Task<DebtDtoResponse> Handle(GetSpecificDebtQuery request, CancellationToken cancellationToken)
        {
            var id = await _debtRepository.GetSpecificDebt(request.id);
            var dto = _mapper.Map<DebtDtoResponse>(id);
            return dto;
        }
    }
}
