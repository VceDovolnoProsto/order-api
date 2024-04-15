using MediatR;
using order_api.application.Common.Interfaces;
using order_api.domain.Entities;

namespace order_api.application.Orders.Commands.Create
{
    public class CreateOrderHandler : IRequestHandler<CreateOrder, Order>
    {
        private readonly IOrdersRepository _ordersRepository;

        public CreateOrderHandler(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public async Task<Order> Handle(CreateOrder request, CancellationToken cancellationToken)
        {
            var newOrder = new Order
            {
                Name = request.Name,
                Cost = request.Cost,
                SourceNote = request.SourceNote
            };

            return await _ordersRepository.CreateOrder(newOrder);
        }
    }
}
