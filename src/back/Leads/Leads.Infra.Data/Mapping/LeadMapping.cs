using Leads.Domain.Entities;
using Leads.SharedKernel.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Leads.Infra.Data.Mapping
{
    public class LeadMapping : IEntityTypeConfiguration<Lead>
    {
        public void Configure(EntityTypeBuilder<Lead> builder)
        {
            builder.Property(e => e.ContactEmail)
                   .HasConversion(new ValueConverter<Email, string>(x => x.Valor, x => x));
        }
    }
}
