using E_bike_Inventory_and_Sales.Entity;
using MediatR;

namespace E_bike_Inventory_and_Sales.Commands.InventoryCommands
{
    public record UpdateInventoryCommand(Inventory Inventory) : IRequest<Inventory>;
}
