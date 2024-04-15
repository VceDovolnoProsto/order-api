using MediatR;
using order_api.application.Orders.Models;
using order_api.domain.Entities;

namespace order_api.application.Orders.Commands.Update
{
    public class UpdateOrder : IRequest<Order>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string SourceNote { get; set; }
        public decimal? Cost { get; set; }

        public UpdateOrder(long id, UpdateOrderDto dto)
        {
            Id = id;
            Name = dto.Name;
            SourceNote = dto.SourceNote;
            Cost = dto.Cost;
        }
    }
}