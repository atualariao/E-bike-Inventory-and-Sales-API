using E_bike_Inventory_and_Sales.Commands.CustomerCommands;
using E_bike_Inventory_and_Sales.Commands.DebtCommands;
using E_bike_Inventory_and_Sales.Data;
using E_bike_Inventory_and_Sales.Dto.Request;
using E_bike_Inventory_and_Sales.Dto.Response;
using E_bike_Inventory_and_Sales.Queries.CustomerQueries;
using E_bike_Inventory_and_Sales.Queries.DebtQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace E_bike_Inventory_and_Sales.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/debt")]
    [Produces("application/json")]
    [ApiController]
    public class DebtController : Controller
    {
        private readonly ISender _sender;

        public DebtController(ISender sender)
        {
            _sender = sender;
        }

        [SwaggerOperation(
                    Summary = "Returns all Debts",
                    Description = "Returns all Debts")]
        [HttpGet]
        public async Task<List<DebtDtoResponse>> GetDebtList()
        {
            try
            {
                return await _sender.Send(new GetDebtListQuery());
            }
            catch (Exception)
            {
                throw;
            }
        }

        [SwaggerOperation(
                    Summary = "Returns a specific debr",
                    Description = "Returns a specific debt")]
        [HttpGet("id")]
        public async Task<DebtDtoResponse> GetSpecificDebt(int id)
        {
            try
            {
                return await _sender.Send(new GetSpecificDebtQuery(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [SwaggerOperation(
                    Summary = "Creates a new debt",
                    Description = "Creates a new debt")]
        [HttpPost]
        public async Task<Debt> CreateDebt(DebtDtoRequest debt)
        {
            try
            {
                return await _sender.Send(new CreateDebtCommand(debt));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [SwaggerOperation(
                    Summary = "Updates a debt's details",
                    Description = "Updates a debt's details")]
        [HttpPut]
        public async Task<Debt> UpdateDebt(DebtDtoReq debt)
        {
            try
            {
                return await _sender.Send(new UpdateDebtCommand(debt));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [SwaggerOperation(
                    Summary = "Deletes a debt",
                    Description = "Deletes a debt")]
        [HttpDelete("id")]
        public async Task<Debt> Delete(int id)
        {
            try
            {
                return await _sender.Send(new DeleteDebtCommand(id));
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
