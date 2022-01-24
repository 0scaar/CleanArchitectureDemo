using CleanArchitectureDemo.Infrastructure.PostgresDataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitectureDemo.Infrastructure.PostgresDataAccess.Map
{
    public class LogDetailMap : IEntityTypeConfiguration<LogDetail>
    {
        public void Configure(EntityTypeBuilder<LogDetail> builder)
        {
            builder.ToTable("LogDetail", "Demo");
            builder.HasKey(d => d.Id);

            builder.Property(p => p.Message).HasMaxLength(20);
            builder.Property(p => p.Line).HasMaxLength(2000).IsRequired();
        }
    }
}
