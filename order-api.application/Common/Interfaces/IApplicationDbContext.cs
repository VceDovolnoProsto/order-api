using Microsoft.EntityFrameworkCore;
using order_api.domain.Entities;

namespace order_api.application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Order> Orders { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
