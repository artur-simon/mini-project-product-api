﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleProjectProduct.EntityFramework;

#nullable disable

namespace SimpleProjectProduct.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20220524154730_Produtos")]
    partial class Produtos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SimpleProjectProduct.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Estoque")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Estoque = 321,
                            Nome = "Helloo",
                            Preco = 3.75
                        },
                        new
                        {
                            Id = 2,
                            Estoque = 2131,
                            Nome = "Hello World! How are you?",
                            Preco = 897.0
                        },
                        new
                        {
                            Id = 3,
                            Estoque = 78678,
                            Nome = "Hello World!",
                            Preco = 124.22
                        },
                        new
                        {
                            Id = 4,
                            Estoque = 65,
                            Nome = "How are you?",
                            Preco = 5678.0
                        },
                        new
                        {
                            Id = 5,
                            Estoque = 667,
                            Nome = "Are you?",
                            Preco = 1.99
                        });
                });
#pragma warning restore 612, 618
        }
    }
}