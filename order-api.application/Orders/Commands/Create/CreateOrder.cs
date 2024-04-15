using MediatR;
using order_api.application.Orders.Models;
using order_api.domain.Entities;

namespace order_api.application.Orders.Commands.Create
{
    public record CreateOrder : IRequest<Order>
    {
        public string Name { get; set; }
        public string SourceNote { get; set; }
        public decimal? Cost { get; set; }

        public CreateOrder(CreateOrderDto dto)
        {
            Name = dto.Name;
            SourceNote = dto.SourceNote;
            Cost = dto.Cost;
        }
    }
}