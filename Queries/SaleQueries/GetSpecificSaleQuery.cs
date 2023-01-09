using E_bike_Inventory_and_Sales.Data;
using MediatR;

namespace E_bike_Inventory_and_Sales.Queries.SaleQueries
{
    public record GetSpecificSaleQuery(int id) : IRequest<Sale>;
}
