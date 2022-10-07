﻿// <auto-generated />
using BLCompanyAPI.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BLCompanyAPI.DataAccess.Migrations
{
    [DbContext(typeof(BLCompanyDbContext))]
    partial class BLCompanyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BLCompanyAPI.Models.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("categoryId"), 1L, 1);

                    b.Property<string>("categoryDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("categoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("categoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BLCompanyAPI.Models.Flower", b =>
                {
                    b.Property<int>("flowerId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("flowerId"), 1L, 1);

                    b.Property<int>("categoryId")
                        .HasColumnType("int");

                    b.Property<string>("flowerDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("flowerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("price")
                        .HasMaxLength(50)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("status")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.HasKey("flowerId");

                    b.HasIndex("categoryId");

                    b.ToTable("Flowers");
                });

            modelBuilder.Entity("BLCompanyAPI.Models.Stock", b =>
                {
                    b.Property<int>("stockId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("stockId"), 1L, 1);

                    b.Property<int>("flowerId")
                        .HasColumnType("int");

                    b.Property<int>("quientity")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("stockName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("stockId");

                    b.HasIndex("flowerId")
                        .IsUnique();

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("BLCompanyAPI.Models.Flower", b =>
                {
                    b.HasOne("BLCompanyAPI.Models.Category", "category")
                        .WithMany("Flowers")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("BLCompanyAPI.Models.Stock", b =>
                {
                    b.HasOne("BLCompanyAPI.Models.Flower", "flower")
                        .WithOne("stock")
                        .HasForeignKey("BLCompanyAPI.Models.Stock", "flowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("flower");
                });

            modelBuilder.Entity("BLCompanyAPI.Models.Category", b =>
                {
                    b.Navigation("Flowers");
                });

            modelBuilder.Entity("BLCompanyAPI.Models.Flower", b =>
                {
                    b.Navigation("stock")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
