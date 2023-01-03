using E_bike_Inventory_and_Sales.Dto.Request;
using E_bike_Inventory_and_Sales.Entity;
using MediatR;

namespace E_bike_Inventory_and_Sales.Commands
{
    public record UpdateCustomerCommand(Customer Customer) : IRequest<Customer>;
}
