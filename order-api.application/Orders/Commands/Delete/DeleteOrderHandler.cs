using MediatR;
using order_api.application.Common.Interfaces;

namespace order_api.application.Orders.Commands.Delete
{
    public class DeleteOrderHandler : IRequestHandler<DeleteOrder>
    {
        private readonly IOrdersRepository _ordersRepository;

        public DeleteOrderHandler(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public async Task Handle(DeleteOrder request, CancellationToken cancellationToken)
        {
            await _ordersRepository.DeleteOrder(request.Id);
        }
    }
}