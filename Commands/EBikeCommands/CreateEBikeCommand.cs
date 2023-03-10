using E_bike_Inventory_and_Sales.Data;
using MediatR;

namespace E_bike_Inventory_and_Sales.Commands.EBikeCommands
{
    public record CreateEBikeCommand(EBike EBike) : IRequest<EBike>;
}
