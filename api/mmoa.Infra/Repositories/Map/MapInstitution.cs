using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mmoa.Domain.Entities;

namespace mmoa.Infra.Repositories.Map
{
    public class MapInstitution : IEntityTypeConfiguration<Institution>
    {
        public void Configure(EntityTypeBuilder<Institution> builder)
        {
            builder.ToTable("Institution");

            ////Propriedades
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();           
            builder.Property(x => x.InstitutionType).IsRequired();           
        }
    }
}
