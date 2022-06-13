﻿// <auto-generated />
using GorevTakipApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GorevTakipApi.Migrations
{
    [DbContext(typeof(GorevTakipDetayContext))]
    partial class GorevTakipDetayContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GorevTakipApi.Models.GorevTakipDetay", b =>
                {
                    b.Property<int>("RecId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GorevBasligi")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gorev")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("KayitTarihi")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nchar(10)");

                    b.Property<string>("TerminTarihi")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("YapilmaTarihi")
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("RecId");

                    b.ToTable("GorevTakipDetays");
                });
#pragma warning restore 612, 618
        }
    }
}