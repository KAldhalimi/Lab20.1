﻿// <auto-generated />
using System;
using EFCoreCoffeeShop.CoffeeShop;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreCoffeeShop.Migrations
{
    [DbContext(typeof(CoffeeShopContext))]
    [Migration("20190727204320_AddedUserName")]
    partial class AddedUserName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreCoffeeShop.CoffeeShop.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int>("Quantity");

                    b.Property<int?>("UserInfoId");

                    b.HasKey("ProductId");

                    b.HasIndex("UserInfoId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EFCoreCoffeeShop.CoffeeShop.UserInfo", b =>
                {
                    b.Property<int>("UserInfoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("UserInfoId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("EFCoreCoffeeShop.CoffeeShop.Product", b =>
                {
                    b.HasOne("EFCoreCoffeeShop.CoffeeShop.UserInfo", "User")
                        .WithMany("Product")
                        .HasForeignKey("UserInfoId");
                });
#pragma warning restore 612, 618
        }
    }
}
