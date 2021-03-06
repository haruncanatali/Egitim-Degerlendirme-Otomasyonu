﻿// <auto-generated />
using Egitim.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Egitim.DataAccess.Migrations
{
    [DbContext(typeof(EgitimDbContext))]
    [Migration("20210220125115_DboEgitimMigration")]
    partial class DboEgitimMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Egitim.Entities.Concrete.Ogretmen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FotoBaglantisi")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("FotoBaglantisi");

                    b.Property<string>("OgretmenAciklama")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OgretmenAciklama");

                    b.Property<string>("OgretmenAdSoyad")
                        .IsRequired()
                        .HasMaxLength(61)
                        .HasColumnType("nvarchar(61)")
                        .HasColumnName("OgretmenAdSoyad");

                    b.Property<string>("OgretmenBrans")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("OgretmenBrans");

                    b.Property<string>("OgretmenPozisyon")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("OgretmenPozisyon");

                    b.Property<decimal>("OgretmenPuan")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("OgretmenPuan");

                    b.Property<int>("OkulId")
                        .HasColumnType("int")
                        .HasColumnName("OkulId");

                    b.HasKey("Id");

                    b.HasIndex("OkulId");

                    b.ToTable("Ogretmenler");
                });

            modelBuilder.Entity("Egitim.Entities.Concrete.OgretmenYorum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Ad");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Mail");

                    b.Property<int>("OgretmenId")
                        .HasColumnType("int")
                        .HasColumnName("OgretmenId");

                    b.Property<decimal>("Puan")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Puan");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Soyad");

                    b.Property<string>("YorumIcerik")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)")
                        .HasColumnName("YorumIcerik");

                    b.HasKey("Id");

                    b.HasIndex("OgretmenId");

                    b.ToTable("OgretmenYorumlari");
                });

            modelBuilder.Entity("Egitim.Entities.Concrete.Okul", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FotoBaglantisi")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("FotoBaglantisi");

                    b.Property<string>("OkulAciklama")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OkulAciklama");

                    b.Property<string>("OkulAdi")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("OkulAdi");

                    b.Property<decimal>("OkulPuan")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("OkulPuan");

                    b.HasKey("Id");

                    b.ToTable("Okullar");
                });

            modelBuilder.Entity("Egitim.Entities.Concrete.OkulYorum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Ad");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Mail");

                    b.Property<int>("OkulId")
                        .HasColumnType("int")
                        .HasColumnName("OkulId");

                    b.Property<decimal>("Puan")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Puan");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Soyad");

                    b.Property<string>("YorumIcerik")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)")
                        .HasColumnName("YorumIcerik");

                    b.HasKey("Id");

                    b.HasIndex("OkulId");

                    b.ToTable("OkulYorumlari");
                });

            modelBuilder.Entity("Egitim.Entities.Concrete.Ogretmen", b =>
                {
                    b.HasOne("Egitim.Entities.Concrete.Okul", "Okulu")
                        .WithMany("Ogretmenler")
                        .HasForeignKey("OkulId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Okulu");
                });

            modelBuilder.Entity("Egitim.Entities.Concrete.OgretmenYorum", b =>
                {
                    b.HasOne("Egitim.Entities.Concrete.Ogretmen", "Ogretmeni")
                        .WithMany("Yorumlar")
                        .HasForeignKey("OgretmenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogretmeni");
                });

            modelBuilder.Entity("Egitim.Entities.Concrete.OkulYorum", b =>
                {
                    b.HasOne("Egitim.Entities.Concrete.Okul", "Okulu")
                        .WithMany("Yorumlar")
                        .HasForeignKey("OkulId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Okulu");
                });

            modelBuilder.Entity("Egitim.Entities.Concrete.Ogretmen", b =>
                {
                    b.Navigation("Yorumlar");
                });

            modelBuilder.Entity("Egitim.Entities.Concrete.Okul", b =>
                {
                    b.Navigation("Ogretmenler");

                    b.Navigation("Yorumlar");
                });
#pragma warning restore 612, 618
        }
    }
}
