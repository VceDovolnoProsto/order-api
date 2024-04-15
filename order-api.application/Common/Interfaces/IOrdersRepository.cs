using order_api.domain.Entities;

namespace order_api.application.Common.Interfaces
{
    // OR use IApplicationDbContext with DBSets and SaveChangesAsync
    public interface IOrdersRepository
    {
        Task<IEnumerable<Order>> GetAll();
        Task<Order?> GetById(long orderId);
        Task<Order> CreateOrder(Order order);
        Task<Order?> UpdateOrder(long orderId, Order order);
        Task DeleteOrder(long orderId);
    }
}