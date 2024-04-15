using MediatR;

namespace order_api.application.Orders.Commands.Delete
{
    public class DeleteOrder : IRequest
    {
        public long Id { get; set; }

        public DeleteOrder(long id)
        {
            Id = id;
        }
    }
}