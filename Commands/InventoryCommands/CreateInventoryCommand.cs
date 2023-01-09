using E_bike_Inventory_and_Sales.Data;
using MediatR;

namespace E_bike_Inventory_and_Sales.Commands.InventoryCommands
{
    public record CreateInventoryCommand(Inventory Inventory) : IRequest<Inventory>;
}
