using E_bike_Inventory_and_Sales.Data;
using MediatR;

namespace E_bike_Inventory_and_Sales.Commands.SaleCommands
{
    public record DeleteSaleCommand(int id) : IRequest<Sale>;
}
