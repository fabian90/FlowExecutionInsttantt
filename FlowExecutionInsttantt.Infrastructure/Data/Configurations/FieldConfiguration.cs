using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FlowExecutionInsttantt.Core.Entities;

namespace FlowExecutionInsttantt.Infrastructure.Data.Configurations
{
    public class FieldConfiguration : IEntityTypeConfiguration<Fields>
    {
        public void Configure(EntityTypeBuilder<Fields> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(e => e.Id)
            .HasColumnName("Id");
            builder.Property(f => f.Code).IsRequired();
        }
    }
}
