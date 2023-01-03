using E_bike_Inventory_and_Sales.Entity;
using MediatR;

namespace E_bike_Inventory_and_Sales.Commands.DebtCommands
{
    public record DeleteDebtCommand(int id) : IRequest<Debt>;
}