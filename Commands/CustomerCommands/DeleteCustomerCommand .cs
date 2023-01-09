using E_bike_Inventory_and_Sales.Data;
using MediatR;

namespace E_bike_Inventory_and_Sales.Commands.CustomerCommands
{
    public record DeleteCustomerCommand(int id) : IRequest<Customer>;
}
