using MediatR;
using order_api.domain.Entities;

namespace order_api.application.Orders.Queries
{
    public class GetAllOrders : IRequest<IEnumerable<Order>>
    {

    }
}