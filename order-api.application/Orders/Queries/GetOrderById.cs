using MediatR;
using order_api.domain.Entities;

namespace order_api.application.Orders.Queries
{
    public class GetOrderById : IRequest<Order>
    {
        public long Id { get; set; }

        public GetOrderById(long id)
        {
            Id = id;
        }
    }
}