using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mmoa.Domain.Entities;

namespace mmoa.Infra.Repositories.Map
{
    public class MapBudgetStandardGroup : IEntityTypeConfiguration<BudgetStandardGroup>
    {
        public void Configure(EntityTypeBuilder<BudgetStandardGroup> builder)
        {
            builder.ToTable("BudgetStandardGroup");

            ////Propriedades
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
        }
    }
}
