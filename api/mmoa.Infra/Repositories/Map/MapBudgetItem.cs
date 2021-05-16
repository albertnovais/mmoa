using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mmoa.Domain.Entities;

namespace mmoa.Infra.Repositories.Map
{
    public class MapBudgetItem : IEntityTypeConfiguration<BudgetItem>
    {
        public void Configure(EntityTypeBuilder<BudgetItem> builder)
        {
            builder.ToTable("BudgetItem");

            ////Propriedades
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.BudgetStandard).IsRequired();
            
        }
    }
}
