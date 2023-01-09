using E_bike_Inventory_and_Sales.Commands.CustomerCommands;
using E_bike_Inventory_and_Sales.Data;
using E_bike_Inventory_and_Sales.Dto.Request;
using E_bike_Inventory_and_Sales.Dto.Response;
using E_bike_Inventory_and_Sales.Queries;
using E_bike_Inventory_and_Sales.Queries.CustomerQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace E_bike_Inventory_and_Sales.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/customers")]
    [Produces("application/json")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ISender _sender;

        public CustomerController(ISender sender)
        {
            _sender = sender;
        }

        [SwaggerOperation(
            Summary = "Returns all Customers",
            Description = "Returns all Customers")]
        [HttpGet]
        public async Task<List<CustomerDtoResponse>> GetCustomerList()
        {
            try
            {
                return await _sender.Send(new GetCustomerListQuery());
            }
            catch (Exception)
            {
                throw;
            }
        }

        [SwaggerOperation(
            Summary = "Returns a specific user",
            Description = "Returns a specific user")]
        [HttpGet("id")]
        public async Task<CustomerDtoResponse> GetSpecificCustomer(int id)
        {
            try
            {
                return await _sender.Send(new GetSpecificCustomerQuery(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [SwaggerOperation(
            Summary = "Creates a new user",
            Description = "Creates a new user")]
        [HttpPost]
        public async Task<Customer> CreateCustomer(CustomerDtoRequest customer)
        {
            try
            {
                return await _sender.Send(new CreateCustomerCommand(customer));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [SwaggerOperation(
            Summary = "Updates a customer's details",
            Description = "Updates a customer's details")]
        [HttpPut]
        public async Task<Customer> UpdateCustomer(CustomerDtoReq customer)
        {
            try
            {
                return await _sender.Send(new UpdateCustomerCommand(customer));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [SwaggerOperation(
            Summary = "Deletes a customer",
            Description = "Deletes a customer")]
        [HttpDelete("id")]
        public async Task<Customer> Delete(int id)
        {
            try
            {
                return await _sender.Send(new DeleteCustomerCommand(id));
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
