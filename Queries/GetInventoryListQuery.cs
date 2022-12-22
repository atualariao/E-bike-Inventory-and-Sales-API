using E_bike_Inventory_and_Sales.Entity;
using MediatR;

namespace E_bike_Inventory_and_Sales.Queries
{
    public record GetInventoryListQuery : IRequest<List<Inventory>>;
}
