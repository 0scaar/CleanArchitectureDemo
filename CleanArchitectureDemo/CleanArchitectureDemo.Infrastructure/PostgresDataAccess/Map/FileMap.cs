using CleanArchitectureDemo.Infrastructure.PostgresDataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitectureDemo.Infrastructure.PostgresDataAccess.Map
{
    public class FileMap : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> builder)
        {
            builder.ToTable("File", "Demo");
            builder.HasKey(d => d.Id);

            builder.Property(p => p.InclusionDate).IsRequired();
            builder.Property(p => p.FileName).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Status).IsRequired();
            builder.Property(p => p.Type).IsRequired();

            builder.HasMany(c => c.Logs)
                .WithOne()
                .HasForeignKey(a => a.FileId);
        }
    }
}
