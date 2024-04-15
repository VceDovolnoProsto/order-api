using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using order_api.domain.Entities;

namespace order_api.domain.Config
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.SourceNote)
                .IsRequired(false);
            builder.Property(x => x.Cost);
        }
    }
}