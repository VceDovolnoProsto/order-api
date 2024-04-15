using MediatR;
using order_api.application.Common.Interfaces;
using order_api.domain.Entities;

namespace order_api.application.Orders.Queries
{
    public class GetAllOrdersHandler : IRequestHandler<GetAllOrders, IEnumerable<Order>>
    {
        private readonly IOrdersRepository _ordersRepository;

        public GetAllOrdersHandler(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public async Task<IEnumerable<Order>> Handle(GetAllOrders request, CancellationToken cancellationToken)
        {
            return await _ordersRepository.GetAll();
        }
    }
}