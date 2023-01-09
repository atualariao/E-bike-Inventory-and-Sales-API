using E_bike_Inventory_and_Sales.Data;
using MediatR;

namespace E_bike_Inventory_and_Sales.Commands.InventoryCommands
{
    public record UpdateInventoryCommand(Inventory Inventory) : IRequest<Inventory>;
}
