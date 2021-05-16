using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mmoa.Domain.Entities;

namespace mmoa.Infra.Repositories.Map
{
    public class MapBudget : IEntityTypeConfiguration<Budget>
    {
        public void Configure(EntityTypeBuilder<Budget> builder)
        {
            builder.ToTable("Budget");

            ////Propriedades
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.Parent);
            builder.Property(x => x.StartDate).IsRequired();
            builder.Property(x => x.User).IsRequired();
            builder.Property(x => x.Duration).IsRequired();
            builder.Property(x => x.DurationType).IsRequired();
        }
    }
}
