using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mmoa.Domain.Entities;

namespace mmoa.Infra.Repositories.Map
{
    public class MapTransactionInfo : IEntityTypeConfiguration<TransactionInfo>
    {
        public void Configure(EntityTypeBuilder<TransactionInfo> builder)
        {
            builder.ToTable("TransactionInfo");

            ////Propriedades
            builder.HasKey(x => x.Id);
            builder.Property(x => x.BudgetItem).IsRequired();
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(256).IsRequired();
            builder.Property(x => x.Transaction).IsRequired();
            builder.Property(x => x.Value).IsRequired();

        }
    }
}
