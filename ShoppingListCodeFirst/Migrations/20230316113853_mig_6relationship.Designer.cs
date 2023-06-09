﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingListCodeFirst.Models;

#nullable disable

namespace ShoppingListCodeFirst.Migrations
{
    [DbContext(typeof(ShoppingListCodeFirstContext))]
    [Migration("20230316113853_mig_6relationship")]
    partial class mig_6relationship
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShoppingListCodeFirst.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ShoppingListCodeFirst.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ShoppingListCodeFirst.Models.ProductList", b =>
                {
                    b.Property<int>("ProductListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductListId"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductListName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("ShopGo")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProductListId");

                    b.HasIndex("UserId");

                    b.ToTable("ProductLists");
                });

            modelBuilder.Entity("ShoppingListCodeFirst.Models.ProductListDetail", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductListId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsBuy")
                        .HasColumnType("bit");

                    b.HasKey("ProductId", "ProductListId");

                    b.HasIndex("ProductListId");

                    b.ToTable("ProductListDetails");
                });

            modelBuilder.Entity("ShoppingListCodeFirst.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ShoppingListCodeFirst.Models.Product", b =>
                {
                    b.HasOne("ShoppingListCodeFirst.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShoppingListCodeFirst.Models.ProductList", b =>
                {
                    b.HasOne("ShoppingListCodeFirst.Models.User", "User")
                        .WithMany("ProductLists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShoppingListCodeFirst.Models.ProductListDetail", b =>
                {
                    b.HasOne("ShoppingListCodeFirst.Models.Product", "Product")
                        .WithMany("ProductListDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ShoppingListCodeFirst.Models.ProductList", "ProductList")
                        .WithMany("ProductListDetails")
                        .HasForeignKey("ProductListId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductList");
                });

            modelBuilder.Entity("ShoppingListCodeFirst.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ShoppingListCodeFirst.Models.Product", b =>
                {
                    b.Navigation("ProductListDetails");
                });

            modelBuilder.Entity("ShoppingListCodeFirst.Models.ProductList", b =>
                {
                    b.Navigation("ProductListDetails");
                });

            modelBuilder.Entity("ShoppingListCodeFirst.Models.User", b =>
                {
                    b.Navigation("ProductLists");
                });
#pragma warning restore 612, 618
        }
    }
}
