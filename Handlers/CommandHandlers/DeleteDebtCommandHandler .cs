using E_bike_Inventory_and_Sales.Commands.DebtCommands;
using E_bike_Inventory_and_Sales.Entity;
using E_bike_Inventory_and_Sales.Repository;
using MediatR;

namespace E_bike_Inventory_and_Sales.Handlers.CommandHandlers
{
    public class DeleteDebtCommandHandler : IRequestHandler<DeleteDebtCommand, Debt>
    {
        private readonly IDebtRepository _debtRepository;

        public DeleteDebtCommandHandler(IDebtRepository debtRepository) => _debtRepository = debtRepository;

        public async Task<Debt> Handle(DeleteDebtCommand request, CancellationToken cancellationToken)
        {
            return await _debtRepository.DeleteDebt(request.id);
        }
    }
}
