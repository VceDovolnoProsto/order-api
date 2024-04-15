using Microsoft.EntityFrameworkCore;
using order_api.domain.Config;
using order_api.domain.Entities;

namespace order_api.infrastructure
{
    public class OrderAppDbContext : DbContext
    {
        public OrderAppDbContext(DbContextOptions<OrderAppDbContext> options) : base(options)
        {}

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddEntities();
        }
    }
}
