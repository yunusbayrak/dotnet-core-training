﻿// <auto-generated />
using System;
using DataAccess.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(JkiContext))]
    [Migration("20200814064811_v9")]
    partial class v9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Entities.Faaliyet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("varchar(5000)")
                        .HasMaxLength(5000);

                    b.Property<string>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("IhbarId")
                        .HasColumnType("int");

                    b.Property<int>("IslemDurumuId")
                        .HasColumnType("int");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Yer")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("IhbarId");

                    b.HasIndex("IslemDurumuId");

                    b.HasIndex("PersonelId");

                    b.ToTable("Faaliyet");
                });

            modelBuilder.Entity("Entity.Entities.Ihbar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("IhbarDurumuId")
                        .HasColumnType("int");

                    b.Property<string>("Ozet")
                        .IsRequired()
                        .HasColumnType("varchar(5000)")
                        .HasMaxLength(5000);

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Yer")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("IhbarDurumuId");

                    b.ToTable("Ihbar");
                });

            modelBuilder.Entity("Entity.Entities.IhbarDurumu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("IhbarDurumu");
                });

            modelBuilder.Entity("Entity.Entities.IslemDurumu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("IslemDurumu");
                });

            modelBuilder.Entity("Entity.Entities.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<string>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("PersonelId")
                        .HasColumnType("int");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("PersonelId");

                    b.HasIndex("RolId");

                    b.ToTable("Kullanici");
                });

            modelBuilder.Entity("Entity.Entities.Olay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("IlkNeden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlusSekli")
                        .IsRequired()
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Yer")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Olay");
                });

            modelBuilder.Entity("Entity.Entities.OlayIhbar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("IhbarId")
                        .HasColumnType("int");

                    b.Property<int>("OlayId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IhbarId");

                    b.HasIndex("OlayId");

                    b.ToTable("OlayIhbar");
                });

            modelBuilder.Entity("Entity.Entities.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Personel");
                });

            modelBuilder.Entity("Entity.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("Entity.Entities.Faaliyet", b =>
                {
                    b.HasOne("Entity.Entities.Ihbar", "Ihbar")
                        .WithMany()
                        .HasForeignKey("IhbarId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entity.Entities.IslemDurumu", "IslemDurumu")
                        .WithMany("Faaliyetler")
                        .HasForeignKey("IslemDurumuId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entity.Entities.Personel", "Personel")
                        .WithMany("Faaliyetler")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Entities.Ihbar", b =>
                {
                    b.HasOne("Entity.Entities.IhbarDurumu", "IhbarDurumu")
                        .WithMany("Ihbarlar")
                        .HasForeignKey("IhbarDurumuId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Entities.Kullanici", b =>
                {
                    b.HasOne("Entity.Entities.Personel", "Personel")
                        .WithMany()
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Entity.Entities.Rol", "Rol")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Entities.OlayIhbar", b =>
                {
                    b.HasOne("Entity.Entities.Ihbar", "Ihbar")
                        .WithMany("OlayIhbarlar")
                        .HasForeignKey("IhbarId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entity.Entities.Olay", "Olay")
                        .WithMany("OlayIhbarlar")
                        .HasForeignKey("OlayId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
