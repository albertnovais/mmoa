using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mmoa.Domain.Entities;

namespace mmoa.Infra.Repositories.Map
{
    public class MapBudgetStandard : IEntityTypeConfiguration<BudgetStandard>
    {
        public void Configure(EntityTypeBuilder<BudgetStandard> builder)
        {
            builder.ToTable("BudgetStandard");

            ////Propriedades
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Budget).IsRequired();
            builder.Property(x => x.BudgetStandardGroup).IsRequired();
            builder.Property(x => x.BudgetStandardType).IsRequired();
            builder.Property(x => x.Weight).IsRequired();
        }
    }
}
