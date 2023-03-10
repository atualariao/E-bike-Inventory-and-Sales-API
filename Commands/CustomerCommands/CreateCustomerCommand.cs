using E_bike_Inventory_and_Sales.Data;
using E_bike_Inventory_and_Sales.Dto.Request;
using MediatR;

namespace E_bike_Inventory_and_Sales.Commands.CustomerCommands
{
    public record CreateCustomerCommand(CustomerDtoRequest Customer) : IRequest<Customer>;
}
