using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitectureDemo.Infrastructure.PostgresDataAccess.Entities.Map
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer", "Demo");
            builder.HasKey(s => s.Id);
            
            builder.Property(d => d.Name).IsRequired();
            builder.Property(d => d.Name).HasMaxLength(200);

            builder.Property(d => d.Age).IsRequired();
            builder.Property(d => d.Email).HasMaxLength(100);

            builder.Property(d => d.DocumentType).IsRequired();
            builder.Property(d => d.DocumentNumber).IsRequired();
            builder.Property(d => d.DocumentNumber).HasMaxLength(20);
        }
    }
}
