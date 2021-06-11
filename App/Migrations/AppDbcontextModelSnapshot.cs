﻿// <auto-generated />
using System;
using App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    partial class AppDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("App.Models.CardItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Quntity")
                        .HasColumnType("int");

                    b.Property<int>("TotalCost")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("CardItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            Quntity = 5,
                            TotalCost = 30000
                        });
                });

            modelBuilder.Entity("App.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameOfCategory")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NameOfCategory = "Sofa and tabel"
                        },
                        new
                        {
                            Id = 2,
                            NameOfCategory = "Carpet"
                        });
                });

            modelBuilder.Entity("App.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Dammam",
                            Email = "Fatma.Alqhtnay94@hotmail.com",
                            FirstName = "Fatimah",
                            LastName = "Alqhtnay",
                            PhoneNumber = 555906886
                        });
                });

            modelBuilder.Entity("App.Models.Furniture", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("CategorisId")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategorisId");

                    b.ToTable("furnitures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 0,
                            Image = "https://www.ikea.com/sa/en/images/products/gammalbyn-3-seat-sofa-beige__0868906_pe781416_s5.jpg",
                            Name = "Sofa ",
                            Price = 3000.0
                        },
                        new
                        {
                            Id = 2,
                            Category = 0,
                            Image = "https://media.wired.com/photos/5f6e50f30cb5c0e55736d793/1:1/w_1800,h_1800,c_limit/Gear-Benchmade-Modern-Tyler-Sofa-SOURCE-Benchmade-Modern.jpg",
                            Name = "Sofa",
                            Price = 2500.0
                        },
                        new
                        {
                            Id = 3,
                            Category = 0,
                            Image = "https://assets.weimgs.com/weimgs/rk/images/wcm/products/202115/0104/tripod-dining-table-walnut-c.jpg",
                            Name = "Tabel with 2 seats",
                            Price = 600.0
                        },
                        new
                        {
                            Id = 4,
                            Category = 0,
                            Image = "https://www.woods-furniture.co.uk/images/products/large/7710.jpg",
                            Name = "Sofa 3 Seater  ",
                            Price = 4000.0
                        },
                        new
                        {
                            Id = 5,
                            Category = 0,
                            Image = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/walmart-sofa-1538774260.jpg?crop=0.923xw:0.462xh;0.0657xw,0.401xh&resize=1200:*",
                            Name = "Sofa",
                            Price = 700.0
                        },
                        new
                        {
                            Id = 6,
                            Category = 0,
                            Image = "https://cdn.shopify.com/s/files/1/0104/1524/3330/products/zoco-home-furnitures-furnitures-tables-round-dining-table-140cm-tab1014-11553669251138_1000x1000.png?v=1606681288",
                            Name = "Round dining table",
                            Price = 600.0
                        });
                });

            modelBuilder.Entity("App.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 22,
                            CustomerId = 1,
                            PaymentType = "Visa Card"
                        });
                });

            modelBuilder.Entity("App.Models.CardItem", b =>
                {
                    b.HasOne("App.Models.Customer", "Customer")
                        .WithOne("CardItems")
                        .HasForeignKey("App.Models.CardItem", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("App.Models.Furniture", b =>
                {
                    b.HasOne("App.Models.Category", "Categoris")
                        .WithMany("Furnitures")
                        .HasForeignKey("CategorisId");

                    b.Navigation("Categoris");
                });

            modelBuilder.Entity("App.Models.Payment", b =>
                {
                    b.HasOne("App.Models.Customer", "Customer")
                        .WithOne("payment")
                        .HasForeignKey("App.Models.Payment", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("App.Models.Category", b =>
                {
                    b.Navigation("Furnitures");
                });

            modelBuilder.Entity("App.Models.Customer", b =>
                {
                    b.Navigation("CardItems");

                    b.Navigation("payment");
                });
#pragma warning restore 612, 618
        }
    }
}