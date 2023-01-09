using E_bike_Inventory_and_Sales.Data;
using E_bike_Inventory_and_Sales.Dto.Request;
using MediatR;

namespace E_bike_Inventory_and_Sales.Commands.DebtCommands
{
    public record CreateDebtCommand(DebtDtoRequest Debt) : IRequest<Debt>;
}
