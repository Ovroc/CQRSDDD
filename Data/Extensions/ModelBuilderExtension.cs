using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder ApplyGlobalConfigurations(this ModelBuilder builder)
        {
            foreach (IMutableEntityType entityType in builder.Model.GetEntityTypes())
            {
                foreach (IMutableProperty property in entityType.GetProperties())
                {
                    switch (property.Name)
                    {
                        case nameof(Entity.Id):
                            property.IsKey();
                            break;
                        case nameof(Entity.DateAdd):
                            property.IsNullable = false;
                            property.SetDefaultValue(DateTime.Now);
                            break;
                        case nameof(Entity.DateUp):
                            property.IsNullable = true;
                            break;
                        default:
                            break;
                    }
                }
            }

            return builder;
        }

        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<Escolaridade>().HasData(
                new Escolaridade { Id = 1, Descricao = EscolaridadeEnum.Infantil.ToString(), DateAdd = DateTime.Now },
                new Escolaridade { Id = 2, Descricao = EscolaridadeEnum.Fundamental.ToString(), DateAdd = DateTime.Now },
                new Escolaridade { Id = 3, Descricao = EscolaridadeEnum.Medio.ToString(), DateAdd = DateTime.Now },
                new Escolaridade { Id = 4, Descricao = EscolaridadeEnum.Superior.ToString(), DateAdd = DateTime.Now }
            );

            return builder;
        }
    }
}
