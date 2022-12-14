// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLayerApp.Repository.AppDBContext;

#nullable disable

namespace NLayerApp.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220902132106_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NLayerApp.Core.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 9, 2, 16, 21, 5, 778, DateTimeKind.Local).AddTicks(6051),
                            Name = "Kalemler",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 9, 2, 16, 21, 5, 778, DateTimeKind.Local).AddTicks(6063),
                            Name = "Kitaplar",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 9, 2, 16, 21, 5, 778, DateTimeKind.Local).AddTicks(6065),
                            Name = "Defterler",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("NLayerApp.Core.Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 9, 2, 16, 21, 5, 778, DateTimeKind.Local).AddTicks(6278),
                            Name = "Kurşun kalem",
                            Price = 100m,
                            Stock = 10,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 9, 2, 16, 21, 5, 778, DateTimeKind.Local).AddTicks(6281),
                            Name = "Dolma kalem",
                            Price = 200m,
                            Stock = 20,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 9, 2, 16, 21, 5, 778, DateTimeKind.Local).AddTicks(6282),
                            Name = "Uçlu kalem",
                            Price = 300m,
                            Stock = 30,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2022, 9, 2, 16, 21, 5, 778, DateTimeKind.Local).AddTicks(6283),
                            Name = "Roman",
                            Price = 400m,
                            Stock = 40,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2022, 9, 2, 16, 21, 5, 778, DateTimeKind.Local).AddTicks(6284),
                            Name = "Bilim kurgu",
                            Price = 500m,
                            Stock = 50,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2022, 9, 2, 16, 21, 5, 778, DateTimeKind.Local).AddTicks(6285),
                            Name = "Gerilim",
                            Price = 600m,
                            Stock = 60,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2022, 9, 2, 16, 21, 5, 778, DateTimeKind.Local).AddTicks(6286),
                            Name = "Çizgili defter",
                            Price = 700m,
                            Stock = 70,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2022, 9, 2, 16, 21, 5, 778, DateTimeKind.Local).AddTicks(6287),
                            Name = "Kareli defter",
                            Price = 800m,
                            Stock = 80,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2022, 9, 2, 16, 21, 5, 778, DateTimeKind.Local).AddTicks(6288),
                            Name = "Çizgisiz defter",
                            Price = 900m,
                            Stock = 90,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("NLayerApp.Core.Entities.Concrete.ProductFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductFeatures", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Kırmızı",
                            Height = 10,
                            ProductId = 1,
                            Width = 10
                        },
                        new
                        {
                            Id = 2,
                            Color = "Mavi",
                            Height = 10,
                            ProductId = 2,
                            Width = 10
                        },
                        new
                        {
                            Id = 3,
                            Color = "Sarı",
                            Height = 10,
                            ProductId = 3,
                            Width = 10
                        },
                        new
                        {
                            Id = 4,
                            Color = "Kırmızı",
                            Height = 30,
                            ProductId = 4,
                            Width = 20
                        },
                        new
                        {
                            Id = 5,
                            Color = "Mavi",
                            Height = 30,
                            ProductId = 5,
                            Width = 20
                        },
                        new
                        {
                            Id = 6,
                            Color = "Sarı",
                            Height = 30,
                            ProductId = 6,
                            Width = 20
                        },
                        new
                        {
                            Id = 7,
                            Color = "Kırmızı",
                            Height = 50,
                            ProductId = 7,
                            Width = 30
                        },
                        new
                        {
                            Id = 8,
                            Color = "Mavi",
                            Height = 50,
                            ProductId = 8,
                            Width = 30
                        },
                        new
                        {
                            Id = 9,
                            Color = "Sarı",
                            Height = 50,
                            ProductId = 9,
                            Width = 30
                        });
                });

            modelBuilder.Entity("NLayerApp.Core.Entities.Concrete.Product", b =>
                {
                    b.HasOne("NLayerApp.Core.Entities.Concrete.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NLayerApp.Core.Entities.Concrete.ProductFeature", b =>
                {
                    b.HasOne("NLayerApp.Core.Entities.Concrete.Product", "Product")
                        .WithOne("ProductFeature")
                        .HasForeignKey("NLayerApp.Core.Entities.Concrete.ProductFeature", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NLayerApp.Core.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("NLayerApp.Core.Entities.Concrete.Product", b =>
                {
                    b.Navigation("ProductFeature");
                });
#pragma warning restore 612, 618
        }
    }
}
