using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public static class ContextMapping
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasKey(usuario => usuario.Id);
            modelBuilder.Entity<Usuario>()
                .Property(usuario => usuario.Nome).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Usuario>()
                .Property(usuario => usuario.Sobrenome).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Usuario>()
                .Property(usuario => usuario.Email).HasMaxLength(100).IsRequired();

            modelBuilder.Entity<Escolaridade>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Escolaridade>()
                .Property(x => x.Descricao).HasMaxLength(80).IsRequired();
        }
    }
}
