using Data.Extensions;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class OneContext : DbContext
    {
        public OneContext(DbContextOptions<OneContext> option) : base(option) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Escolaridade> Escolaridades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ContextMapping.Map(modelBuilder);

            modelBuilder.ApplyGlobalConfigurations();
            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
