﻿// <auto-generated />
using System;
using FinancasApp.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinancasApp.Infra.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240720200907_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinancasApp.Domain.Entities.Conta", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Data")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("DESCRICAO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NOME");

                    b.Property<int>("Tipo")
                        .HasColumnType("int")
                        .HasColumnName("TIPO");

                    b.Property<decimal?>("Valor")
                        .IsRequired()
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("VALOR");

                    b.HasKey("Id");

                    b.ToTable("CONTA", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
