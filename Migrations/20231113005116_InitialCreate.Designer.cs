﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apiPrueba.Infraestructure.Context;

#nullable disable

namespace apiPrueba.Migrations
{
    [DbContext(typeof(ECommerceContext))]
    [Migration("20231113005116_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("apiPrueba.infraestructure.entity.ItemEntity", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemID"));

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("ShoppingCartEntityShoppingCardID")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingCartID")
                        .HasColumnType("int");

                    b.HasKey("ItemID");

                    b.HasIndex("ShoppingCartEntityShoppingCardID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("apiPrueba.infraestructure.entity.ShoppingCartEntity", b =>
                {
                    b.Property<int>("ShoppingCardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingCardID"));

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCardID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("apiPrueba.infraestructure.entity.UserEntity", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("apiPrueba.infraestructure.entity.ItemEntity", b =>
                {
                    b.HasOne("apiPrueba.infraestructure.entity.ShoppingCartEntity", null)
                        .WithMany("Items")
                        .HasForeignKey("ShoppingCartEntityShoppingCardID");
                });

            modelBuilder.Entity("apiPrueba.infraestructure.entity.ShoppingCartEntity", b =>
                {
                    b.HasOne("apiPrueba.infraestructure.entity.UserEntity", "User")
                        .WithOne("ShoppingCart")
                        .HasForeignKey("apiPrueba.infraestructure.entity.ShoppingCartEntity", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("apiPrueba.infraestructure.entity.ShoppingCartEntity", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("apiPrueba.infraestructure.entity.UserEntity", b =>
                {
                    b.Navigation("ShoppingCart")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
