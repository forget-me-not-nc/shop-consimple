using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configs.ModelConfigs
{
    public class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.ToTable("OrderProducts");
            builder.HasKey(op => new { op.ProductId, op.OrderId });

            builder.HasOne(op => op.Product)
                   .WithMany(p => p.Orders)
                   .HasForeignKey(op => op.ProductId);

            builder.HasOne(op => op.Order)
                   .WithMany(o => o.Products)
                   .HasForeignKey(op => op.OrderId);

        }
    }
}
