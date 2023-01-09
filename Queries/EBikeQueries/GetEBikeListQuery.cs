using E_bike_Inventory_and_Sales.Data;
using MediatR;

namespace E_bike_Inventory_and_Sales.Queries.EBikeQueries
{
    public record GetEBikeListQuery : IRequest<List<EBike>>;
}
