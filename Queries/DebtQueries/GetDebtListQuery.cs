using E_bike_Inventory_and_Sales.Dto.Response;
using MediatR;

namespace E_bike_Inventory_and_Sales.Queries.DebtQueries
{
    public record GetDebtListQuery : IRequest<List<DebtDtoResponse>>;
}
