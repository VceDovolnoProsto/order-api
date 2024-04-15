using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using order_api.application.Orders.Commands.Create;
using order_api.application.Orders.Commands.Delete;
using order_api.application.Orders.Commands.Update;
using order_api.application.Orders.Models;
using order_api.application.Orders.Queries;

namespace order_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public OrdersController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDto>>> GetOrders()
        {
            var result = await _mediator.Send(new GetAllOrders());
            
            return Ok(result.Select(_mapper.Map<OrderDto>));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDto>> GetOrder(long id)
        {
            var order = await _mediator.Send(new GetOrderById(id));

            if (order == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<OrderDto>(order));
        }

        [HttpPost]
        public async Task<ActionResult<OrderDto>> CreateOrder([FromBody] CreateOrderDto dto)
        {
            var order = await _mediator.Send(new CreateOrder(dto));

            return Ok(_mapper.Map<OrderDto>(order));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(long id, [FromBody] UpdateOrderDto dto)
        {
            await _mediator.Send(new UpdateOrder(id, dto));

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(long id)
        {
            await _mediator.Send(new DeleteOrder(id));

            return NoContent();
        }
    }
}
