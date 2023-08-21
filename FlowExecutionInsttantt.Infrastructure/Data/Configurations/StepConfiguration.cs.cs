using FlowExecutionInsttantt.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlowExecutionInsttantt.Infrastructure.Data.Configurations
{
    public class StepConfiguration : IEntityTypeConfiguration<Steps>
    {
        public void Configure(EntityTypeBuilder<Steps> builder)
        {
            builder.ToTable("Step");
            builder.HasKey(s => s.Id);
            builder.Property(e => e.Id)
              .HasColumnName("Id");
            builder.Property(s => s.Code).IsRequired().HasMaxLength(50);
        }
    }
}
