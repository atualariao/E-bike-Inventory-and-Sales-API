using E_bike_Inventory_and_Sales.Dto.Request;
using E_bike_Inventory_and_Sales.Entity;
using MediatR;

namespace E_bike_Inventory_and_Sales.Commands.DebtCommands
{
    public record UpdateDebtCommand(DebtDtoReq Debt) : IRequest<Debt>;
}
