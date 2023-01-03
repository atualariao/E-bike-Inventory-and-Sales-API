using E_bike_Inventory_and_Sales.Dto.Request;
using E_bike_Inventory_and_Sales.Dto.Response;
using MediatR;

namespace E_bike_Inventory_and_Sales.Queries
{
    public record GetSpecificCustomerQuery(int id) : IRequest<CustomerDtoResponse>;
}
