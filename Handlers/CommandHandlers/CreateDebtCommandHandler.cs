using AutoMapper;
using E_bike_Inventory_and_Sales.Commands.CustomerCommands;
using E_bike_Inventory_and_Sales.Commands.DebtCommands;
using E_bike_Inventory_and_Sales.Dto.Request;
using E_bike_Inventory_and_Sales.Entity;
using E_bike_Inventory_and_Sales.Repository;
using MediatR;

namespace E_bike_Inventory_and_Sales.Handlers.CommandHandlers
{
    public class CreateDebtCommandHandler : IRequestHandler<CreateDebtCommand, Debt>
    {
        private readonly IDebtRepository _debtRepository;
        private readonly IMapper _mapper;

        public CreateDebtCommandHandler(IDebtRepository debtRepository, IMapper mapper)
        {
            _debtRepository = debtRepository;
            _mapper = mapper;
        }

        public async Task<Debt> Handle(CreateDebtCommand request, CancellationToken cancellationToken)
        {
            var debtDto = new DebtDtoRequest()
            {
                Amount = request.Debt.Amount,
                CustomerId = request.Debt.CustomerId,
                Date = DateTime.Now
            };

            Debt debt = _mapper.Map<Debt>(debtDto);
            return await _debtRepository.CreateDebt(debt);
        }

    }
}
