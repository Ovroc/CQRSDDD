﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(OneContext))]
    partial class OneContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Escolaridade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 9, 18, 20, 50, 7, 112, DateTimeKind.Local).AddTicks(7057));

                    b.Property<DateTime?>("DateUp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Escolaridades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAdd = new DateTime(2022, 9, 18, 20, 50, 7, 122, DateTimeKind.Local).AddTicks(579),
                            Descricao = "Infantil"
                        },
                        new
                        {
                            Id = 2,
                            DateAdd = new DateTime(2022, 9, 18, 20, 50, 7, 122, DateTimeKind.Local).AddTicks(939),
                            Descricao = "Fundamental"
                        },
                        new
                        {
                            Id = 3,
                            DateAdd = new DateTime(2022, 9, 18, 20, 50, 7, 122, DateTimeKind.Local).AddTicks(952),
                            Descricao = "Medio"
                        },
                        new
                        {
                            Id = 4,
                            DateAdd = new DateTime(2022, 9, 18, 20, 50, 7, 122, DateTimeKind.Local).AddTicks(954),
                            Descricao = "Superior"
                        });
                });

            modelBuilder.Entity("Domain.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateAdd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 9, 18, 20, 50, 7, 121, DateTimeKind.Local).AddTicks(3507));

                    b.Property<DateTime?>("DateUp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("EscolaridadeId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EscolaridadeId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Domain.Models.Usuario", b =>
                {
                    b.HasOne("Domain.Models.Escolaridade", "Escolaridade")
                        .WithMany()
                        .HasForeignKey("EscolaridadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escolaridade");
                });
#pragma warning restore 612, 618
        }
    }
}