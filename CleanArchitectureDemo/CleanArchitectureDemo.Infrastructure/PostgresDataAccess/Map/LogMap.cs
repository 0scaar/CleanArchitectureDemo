using CleanArchitectureDemo.Infrastructure.PostgresDataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitectureDemo.Infrastructure.PostgresDataAccess.Map
{
    public class LogMap : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.ToTable("Log", "Demo");
            builder.HasKey(d => d.Id);

            builder.Property(p => p.Service).HasMaxLength(50).IsRequired();
            builder.Property(p => p.TypeLog).IsRequired();
            builder.Property(p => p.StackTrace).HasMaxLength(3000);
            builder.Property(p => p.Message).IsRequired().HasMaxLength(400);
            builder.Property(p => p.DateLog).IsRequired();

            builder.HasMany(c => c.LogDetails)
                .WithOne()
                .HasForeignKey(c => c.LogId);
        }
    }
}
