using MediatR;
using order_api.application.Common.Interfaces;
using order_api.domain.Entities;

namespace order_api.application.Orders.Queries
{
    public class GetOrderByIdHandler : IRequestHandler<GetOrderById, Order?>
    {
        private readonly IOrdersRepository _ordersRepository;

        public GetOrderByIdHandler(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public async Task<Order?> Handle(GetOrderById request, CancellationToken cancellationToken)
        {
            return await _ordersRepository.GetById(request.Id);
        }
    }
}