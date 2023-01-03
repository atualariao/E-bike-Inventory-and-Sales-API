using AutoMapper;
using E_bike_Inventory_and_Sales.Dto.Response;
using E_bike_Inventory_and_Sales.Interface;
using E_bike_Inventory_and_Sales.Queries.CustomerQueries;
using E_bike_Inventory_and_Sales.Queries.DebtQueries;
using MediatR;

namespace E_bike_Inventory_and_Sales.Handlers.QueryHandlers
{
    public class GetDebtListQueryHandler : IRequestHandler<GetDebtListQuery, List<DebtDtoResponse>>
    {
        private readonly IDebtRepository _debtRepository;
        private readonly IMapper _mapper;

        public GetDebtListQueryHandler(IDebtRepository debtRepository, IMapper mapper)
        {
            _debtRepository = debtRepository;
            _mapper = mapper;
        }

        public async Task<List<DebtDtoResponse>> Handle(GetDebtListQuery request, CancellationToken cancellationToken)
        {
            var dto = await _debtRepository.GetDebtList();
            var debt = _mapper.Map<List<DebtDtoResponse>>(dto);
            return debt;
        }

    }
}
