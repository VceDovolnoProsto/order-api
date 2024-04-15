using MediatR;
using order_api.application.Common.Interfaces;
using order_api.domain.Entities;

namespace order_api.application.Orders.Commands.Update
{
    public class UpdateOrderHandler : IRequestHandler<UpdateOrder, Order>
    {
        private readonly IOrdersRepository _ordersRepository;

        public UpdateOrderHandler(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public async Task<Order> Handle(UpdateOrder request, CancellationToken cancellationToken)
        {
            var updatedOrder = new Order
            {
                Name = request.Name,
                SourceNote = request.SourceNote,
                Cost = request.Cost
            };

            return await _ordersRepository.UpdateOrder(request.Id, updatedOrder);
        }
    }
}