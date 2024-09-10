﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _9kcars.Data;

#nullable disable

namespace _9kcars.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240910212713_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("_9kcars.Entities.Veiculo", b =>
                {
                    b.Property<int>("VeiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Ano")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool?>("Disponibilidade")
                        .IsRequired()
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.Property<decimal?>("Valor")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("VeiculoId");

                    b.ToTable("Veiculos");

                    b.HasData(
                        new
                        {
                            VeiculoId = 1,
                            Ano = 1991,
                            Categoria = "Sports Car",
                            Cor = "Formula Red",
                            Disponibilidade = true,
                            Marca = "Acura",
                            Modelo = "NSX",
                            Placa = "ABC-1234",
                            Valor = 800m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
