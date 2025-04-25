using Core.Constants;
using Core.CustomExceptions;
using Core.Queries.Orders;
using DTO.Requests.Orders;
using DTO.Response.Orders;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ShopConsimple.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController: ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(IMediator mediator, ILogger<OrdersController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost("recent-customers")]
        public async Task<ActionResult<GetRecentCustomersResponse>> GetRecentCusomers([FromBody] GetRecentCustomersRequest request)
        {
            try
            {
                var response = await _mediator.Send(new GetRecentCustomersCommand(request));
                return Ok(response);
            }
            catch (CustomExceptionBase ex)
            {
                _logger.LogWarning(ex, $"A custom exception occurred while retrieving recent cusomers: {request}.");
                return StatusCode(ex.ErrorCode, new { ex.Message });
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"An unexpected error occurred while retrieving recent cusomers: {request}.");
                return StatusCode(SystemConstants.Exceptions.DefaultInternalErrorCode, new { SystemConstants.Exceptions.DefaultInternalErrorMessage });
            }
        }
    }
}
