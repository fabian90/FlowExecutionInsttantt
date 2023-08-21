using FlowExecutionInsttantt.Core.Entities;
using FlowExecutionInsttantt.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;

namespace FlowExecutionInsttantt.Infrastructure.Data
{
    public class IdentityDBContext : DbContext
    {
        public IdentityDBContext(DbContextOptions<IdentityDBContext> options) : base(options)
        {
        }

        public virtual DbSet<ErrorLog> errorLog { get; set; }
        public DbSet<Steps> Steps { get; set; }
        public DbSet<Fields> Fields { get; set; }
        public DbSet<StepInputRelations> StepInputRelations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
