using FlowExecutionInsttantt.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlowExecutionInsttantt.Infrastructure.Data.Configurations
{
    public class StepInputRelationConfiguration : IEntityTypeConfiguration<StepInputRelations>
    {
        public void Configure(EntityTypeBuilder<StepInputRelations> builder)
        {
            builder.ToTable("StepInputRelations");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.FieldId)
               .IsRequired();

            builder.Property(e => e.StepId)
               .IsRequired();

            builder.HasOne(d => d.Steps)
                   .WithMany(p => p.InputRelations)
                   .HasForeignKey(d => d.StepId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_StepsInputRelations");
            builder.HasOne(d => d.Fields)
                  .WithMany(p => p.InputRelations)
                  .HasForeignKey(d => d.StepId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_FieldsInputRelations");


        }
    }
}
