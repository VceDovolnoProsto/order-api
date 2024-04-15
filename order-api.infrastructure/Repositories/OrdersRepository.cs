using Microsoft.EntityFrameworkCore;
using order_api.application.Common.Interfaces;
using order_api.domain.Entities;

namespace order_api.infrastructure.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly OrderAppDbContext _context;

        public OrdersRepository(OrderAppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order?> GetById(long orderId)
        {
            return await _context.Orders.FirstOrDefaultAsync(x => x.Id == orderId);
        }

        public async Task<Order> CreateOrder(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            return order;
        }

        public async Task<Order?> UpdateOrder(long orderId, Order order)
        {
            var existingOrder = await _context.Orders.FirstOrDefaultAsync(x => x.Id == orderId);

            if (existingOrder != null)
            {
                existingOrder.Name = order.Name;
                existingOrder.SourceNote = order.SourceNote;
                existingOrder.Cost = order.Cost;

                await _context.SaveChangesAsync();
            }

            return existingOrder;
        }

        public async Task DeleteOrder(long orderId)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == orderId);

            if (order != null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
        }
    }
}