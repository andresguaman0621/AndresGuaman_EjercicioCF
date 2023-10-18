﻿// <auto-generated />
using System;
using AndresGuaman_EjercicioCF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AndresGuaman_EjercicioCF.Migrations
{
    [DbContext(typeof(AndresGuaman_EjercicioCFContext))]
    partial class AndresGuaman_EjercicioCFContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AndresGuaman_EjercicioCF.Models.Burger", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("WithCheese")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Burger");
                });

            modelBuilder.Entity("AndresGuaman_EjercicioCF.Models.Promo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("BurgerID")
                        .HasColumnType("int");

                    b.Property<string>("PromoDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PromoID")
                        .HasColumnType("int");

                    b.Property<string>("PromoName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BurgerID");

                    b.ToTable("Promo");
                });

            modelBuilder.Entity("AndresGuaman_EjercicioCF.Models.Promo", b =>
                {
                    b.HasOne("AndresGuaman_EjercicioCF.Models.Burger", "Burger")
                        .WithMany("Promo")
                        .HasForeignKey("BurgerID");

                    b.Navigation("Burger");
                });

            modelBuilder.Entity("AndresGuaman_EjercicioCF.Models.Burger", b =>
                {
                    b.Navigation("Promo");
                });
#pragma warning restore 612, 618
        }
    }
}
