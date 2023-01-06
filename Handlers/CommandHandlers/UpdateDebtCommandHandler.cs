using AutoMapper;
using E_bike_Inventory_and_Sales.Commands.CustomerCommands;
using E_bike_Inventory_and_Sales.Commands.DebtCommands;
using E_bike_Inventory_and_Sales.Dto.Request;
using E_bike_Inventory_and_Sales.Entity;
using E_bike_Inventory_and_Sales.Repository;
using MediatR;

namespace E_bike_Inventory_and_Sales.Handlers.CommandHandlers
{
    public class UpdateDebtCommandHandler : IRequestHandler<UpdateDebtCommand, Debt>
    {
        private readonly IDebtRepository _debtRepository;
        private readonly IMapper _mapper;

        public UpdateDebtCommandHandler(IDebtRepository debtRepository, IMapper mapper)
        {
            _debtRepository = debtRepository;
            _mapper = mapper;
        }

        public async Task<Debt> Handle(UpdateDebtCommand request, CancellationToken cancellationToken)
        {
            var updateDebt = new DebtDtoReq()
            {
                Id = request.Debt.Id,
                Amount = request.Debt.Amount,
                CustomerId = request.Debt.CustomerId,
            };

            Debt debt = _mapper.Map<Debt>(updateDebt);
            return await _debtRepository.UpdateDebt(debt);
        }

    }
}
