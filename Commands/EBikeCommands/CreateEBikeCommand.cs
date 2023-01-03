using E_bike_Inventory_and_Sales.Entity;
using MediatR;

namespace E_bike_Inventory_and_Sales.Commands.EBikeCommands
{
    public record CreateEBikeCommand(EBike EBike) : IRequest<EBike>;
}
