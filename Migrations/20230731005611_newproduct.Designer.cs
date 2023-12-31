﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using shoppingWebApi.Data;

#nullable disable

namespace shoppingWebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230731005611_newproduct")]
    partial class newproduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("shoppingWebApi.models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<int?>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("order");
                });

            modelBuilder.Entity("shoppingWebApi.models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("fastCharge")
                        .HasColumnType("bit");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("waterproof")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            brand = "Philips",
                            fastCharge = true,
                            image = "https://www.maquinilladeafeitar.com/wp-content/uploads/2018/01/Philips-serie-7000.jpg",
                            model = "Series 7000",
                            price = 150,
                            rating = 5,
                            stock = 10,
                            type = "Shaver",
                            waterproof = true
                        },
                        new
                        {
                            Id = 2,
                            brand = "Braun",
                            fastCharge = false,
                            image = "https://images-na.ssl-images-amazon.com/images/I/811IO5eKSJL._AC_SL1500_.jpg",
                            model = "Series 9",
                            price = 250,
                            rating = 4,
                            stock = 20,
                            type = "Shaver",
                            waterproof = true
                        },
                        new
                        {
                            Id = 3,
                            brand = "Panasonic",
                            fastCharge = true,
                            image = "https://moo.review/wp-content/uploads/2016/02/Panasonic-Arc-5-model-ES-LV9N-electric-shaver.jpg",
                            model = "Arc5",
                            price = 200,
                            rating = 4,
                            stock = 15,
                            type = "Shaver",
                            waterproof = true
                        },
                        new
                        {
                            Id = 4,
                            brand = "Philips",
                            fastCharge = false,
                            image = "https://www.philips.be/c-dam/corporate/newscenter/be/standard/resources/2017/one-blade/philips-one-blade-hi-res-02.download.jpg",
                            model = "OneBlade",
                            price = 50,
                            rating = 4,
                            stock = 30,
                            type = "Shaver",
                            waterproof = true
                        },
                        new
                        {
                            Id = 5,
                            brand = "Philips",
                            fastCharge = false,
                            image = "https://www.bigw.com.au/medias/sys_master/images/images/hb5/h95/10815612026910.jpg",
                            model = "AquaTouch",
                            price = 80,
                            rating = 3,
                            stock = 20,
                            type = "Shaver",
                            waterproof = true
                        },
                        new
                        {
                            Id = 6,
                            brand = "Philips",
                            fastCharge = true,
                            image = "https://top-rasage.fr/wp-content/uploads/2018/02/Philips-Series-5000-S531026.jpg",
                            model = "Series 5000",
                            price = 120,
                            rating = 5,
                            stock = 10,
                            type = "Shaver",
                            waterproof = true
                        },
                        new
                        {
                            Id = 7,
                            brand = "Braun",
                            fastCharge = true,
                            image = "https://www.bestshaverszone.com/wp-content/uploads/2015/03/Braun-Series-7-790cc-Pulsonic.jpg",
                            model = "Series 7",
                            price = 180,
                            rating = 4,
                            stock = 25,
                            type = "Shaver",
                            waterproof = true
                        },
                        new
                        {
                            Id = 8,
                            brand = "Braun",
                            fastCharge = false,
                            image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/5895/5895021_rd.jpg",
                            model = "Series 5",
                            price = 130,
                            rating = 4,
                            stock = 15,
                            type = "Shaver",
                            waterproof = true
                        },
                        new
                        {
                            Id = 9,
                            brand = "Braun",
                            fastCharge = false,
                            image = "https://www.mashco.co.uk/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/b/r/bra3000s.png",
                            model = "Series 3 ProSkin",
                            price = 70,
                            rating = 3,
                            stock = 20,
                            type = "Shaver",
                            waterproof = true
                        },
                        new
                        {
                            Id = 10,
                            brand = "Panasonic",
                            fastCharge = true,
                            image = "https://d11zer3aoz69xt.cloudfront.net/media/catalog/product/cache/1/image/1200x/9df78eab33525d08d6e5fb8d27136e95/p/a/panasonic_arc4_4-blade_shaver_es-lf51-a_11.jpg",
                            model = "Arc4",
                            price = 120,
                            rating = 4,
                            stock = 15,
                            type = "Shaver",
                            waterproof = true
                        },
                        new
                        {
                            Id = 11,
                            brand = "Panasonic",
                            fastCharge = false,
                            image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6400/6400550_rd.jpg",
                            model = "Arc3",
                            price = 90,
                            rating = 4,
                            stock = 20,
                            type = "Shaver",
                            waterproof = true
                        },
                        new
                        {
                            Id = 12,
                            brand = "Panasonic",
                            fastCharge = true,
                            image = "https://c1.neweggimages.com/ProductImageCompressAll1280/96-200-517-02.jpg",
                            model = "ES-LV95-S",
                            price = 200,
                            rating = 5,
                            stock = 10,
                            type = "Shaver",
                            waterproof = true
                        });
                });

            modelBuilder.Entity("shoppingWebApi.models.ProductItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.Property<int?>("orderId")
                        .HasColumnType("int");

                    b.Property<int?>("productId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("orderId");

                    b.HasIndex("productId");

                    b.ToTable("ProductItems");
                });

            modelBuilder.Entity("shoppingWebApi.models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("passwordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("shoppingWebApi.models.Order", b =>
                {
                    b.HasOne("shoppingWebApi.models.User", "user")
                        .WithMany("orders")
                        .HasForeignKey("userId");

                    b.Navigation("user");
                });

            modelBuilder.Entity("shoppingWebApi.models.ProductItem", b =>
                {
                    b.HasOne("shoppingWebApi.models.Order", "order")
                        .WithMany("item")
                        .HasForeignKey("orderId");

                    b.HasOne("shoppingWebApi.models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productId");

                    b.Navigation("order");

                    b.Navigation("product");
                });

            modelBuilder.Entity("shoppingWebApi.models.Order", b =>
                {
                    b.Navigation("item");
                });

            modelBuilder.Entity("shoppingWebApi.models.User", b =>
                {
                    b.Navigation("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
