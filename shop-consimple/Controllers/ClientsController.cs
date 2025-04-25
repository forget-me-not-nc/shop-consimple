using Core.Constants;
using Core.CustomExceptions;
using Core.Queries.Clients;
using DTO.Response.Clients;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ShopConsimple.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController: ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ClientsController> _logger;

        public ClientsController(IMediator mediator, ILogger<ClientsController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("birthdays")]
        public async Task<ActionResult<GetClientsWithBirthdayReponse>> GetClientsWithBirthdays([FromQuery] DateTime date)
        {
            try
            {
                var response = await _mediator.Send(new GetClientsWithBirthdaysCommand(date));
                return Ok(response);
            }
            catch (CustomExceptionBase ex)
            {
                _logger.LogWarning(ex, $"A custom exception occurred while retrieving clients with birthdays for date {date}.");
                return StatusCode(ex.ErrorCode, new { ex.Message });
            }
            catch (Exception ex)
            {
               
                _logger.LogError(ex, $"An unexpected error occurred while retrieving clients with birthdays for date: {date}.");
                return StatusCode(SystemConstants.Exceptions.DefaultInternalErrorCode, new { SystemConstants.Exceptions.DefaultInternalErrorMessage }); 
            }
        }


        [HttpGet("categories-statistic")]
        public async Task<ActionResult<GetClientsWithBirthdayReponse>> GetCategoriesStatisticByClient([FromQuery] int clientId)
        {
            try
            {
                var response = await _mediator.Send(new GetCategoriesStatisticByClientCommand(clientId));
                return Ok(response);
            }
            catch (CustomExceptionBase ex)
            {
                _logger.LogWarning(ex, $"A custom exception occurred while retrieving clients categories statistic: clientId {clientId}.");
                return StatusCode(ex.ErrorCode, new { ex.Message });
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"An unexpected error occurred while retrieving clients categories statistic: clientId {clientId}.");
                return StatusCode(SystemConstants.Exceptions.DefaultInternalErrorCode, new { SystemConstants.Exceptions.DefaultInternalErrorMessage });
            }
        }
    }
}
