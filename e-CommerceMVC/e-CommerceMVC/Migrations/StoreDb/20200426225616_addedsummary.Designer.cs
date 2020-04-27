﻿// <auto-generated />
using ECommerceMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommerceMVC.Migrations.StoreDb
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20200426225616_addedsummary")]
    partial class addedsummary
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ECommerceMVC.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SKU")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Inventories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Website that is tailor to business with exquisite taste in classical theme. This outline will grab all of the antiquity enthusiast ",
                            Image = "https://i.imgur.com/ex7bvr4.jpg",
                            Name = "Classic",
                            Price = 150.00m,
                            SKU = "12jrj830"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Website that is designed for gen-z business owner. This site will captivate customers that favorites new trend.",
                            Image = "https://i.imgur.com/KckYFPo.jpg",
                            Name = "Hipster",
                            Price = 300.00m,
                            SKU = "8fw4s10"
                        },
                        new
                        {
                            ID = 3,
                            Description = "Website that gear towards older generation customer. Very comprehensive and well designed website that will increase your profit immediately.",
                            Image = "https://i.imgur.com/rIRLFbX.jpg",
                            Name = "Antique",
                            Price = 180.00m,
                            SKU = "4nj38s10"
                        },
                        new
                        {
                            ID = 4,
                            Description = "Website that is for comic fan user. This design will flourish with incoming traffic of comic and action hero lovers.",
                            Image = "https://i.imgur.com/xf5nzhK.jpg",
                            Name = "Comic",
                            Price = 210.00m,
                            SKU = "7mj38s10"
                        },
                        new
                        {
                            ID = 5,
                            Description = "Website that is one of our best seller. This nature design is sure to bring people who wants to be away from fast paced society and enjoy what nature has to offer.",
                            Image = "https://i.imgur.com/1k8nogz.jpg",
                            Name = "Nature",
                            Price = 2000.00m,
                            SKU = "12j38s10"
                        },
                        new
                        {
                            ID = 6,
                            Description = "Website that aims to change and new things in the market. This website breathe in scalability and agile.",
                            Image = "https://i.imgur.com/q1OefoY.jpg",
                            Name = "Technical",
                            Price = 200.00m,
                            SKU = "8fg38s10"
                        },
                        new
                        {
                            ID = 7,
                            Description = "Website that is affordable and simple to user's eyes. The format is easy to follow and navigate.",
                            Image = "https://i.imgur.com/lJrL4Sr.jpg",
                            Name = "Greyscale",
                            Price = 75.00m,
                            SKU = "8fw8s10"
                        },
                        new
                        {
                            ID = 8,
                            Description = "Website that just looking at it brings coziness in your heart. Having this design will leave you with christmas everyday.",
                            Image = "https://i.imgur.com/ZesihIk.jpg",
                            Name = "Cozy",
                            Price = 240.00m,
                            SKU = "yv538s10"
                        },
                        new
                        {
                            ID = 9,
                            Description = "Website that pursue on innovation and vibrant schema. This website illustrate all of the beautiful colors in the world into one. Sure to bring in heavy traffic.",
                            Image = "https://i.imgur.com/26bU5zY.png",
                            Name = "Colorful",
                            Price = 350.00m,
                            SKU = "83nd8fn3"
                        },
                        new
                        {
                            ID = 10,
                            Description = "Website that thrives in modern society and its fast changes. This website is for end user with modern taste and elegant details.",
                            Image = "https://i.imgur.com/aHUKS0C.png",
                            Name = "Modern",
                            Price = 200.00m,
                            SKU = "8fj38s10"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
