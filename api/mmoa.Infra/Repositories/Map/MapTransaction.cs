using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mmoa.Domain.Entities;

namespace mmoa.Infra.Repositories.Map
{
    public class MapTransaction : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");

            ////Propriedades
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Institution).IsRequired();
            builder.Property(x => x.IsEntry).IsRequired();
            builder.Property(x => x.IsSameHolder).IsRequired();
            builder.Property(x => x.User).IsRequired();
        }
    }
}
