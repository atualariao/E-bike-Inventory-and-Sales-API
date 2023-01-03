using E_bike_Inventory_and_Sales.Dto.Response;
using E_bike_Inventory_and_Sales.Entity;
using MediatR;

namespace E_bike_Inventory_and_Sales.Queries.DebtQueries
{
    public record GetSpecificDebtQuery(int id) : IRequest<DebtDtoResponse>;
}
