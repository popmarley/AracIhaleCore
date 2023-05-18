﻿// <auto-generated />
using System;
using AracIhale.API.MyContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AracIhale.API.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20230518115147_12")]
    partial class _12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AracIhale.API.DTO.AracMarka", b =>
                {
                    b.Property<int>("MarkaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("MarkaAdi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MarkaID");

                    b.ToTable("AracMarkas");
                });

            modelBuilder.Entity("AracIhale.API.DTO.AracModel", b =>
                {
                    b.Property<int>("AracModelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AracMarkaID")
                        .HasColumnType("int");

                    b.Property<string>("ModelAdi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AracModelID");

                    b.HasIndex("AracMarkaID");

                    b.ToTable("AracModels");
                });

            modelBuilder.Entity("AracIhale.API.DTO.AracOzellik", b =>
                {
                    b.Property<int>("AracOzellikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AracMarkaID")
                        .HasColumnType("int");

                    b.Property<int?>("AracModelID")
                        .HasColumnType("int");

                    b.Property<int?>("GovdeTipiID")
                        .HasColumnType("int");

                    b.Property<string>("OpsiyonelDonanim")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("RenkID")
                        .HasColumnType("int");

                    b.Property<string>("Versiyon")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("VitesTipiID")
                        .HasColumnType("int");

                    b.Property<int?>("YakitTipiID")
                        .HasColumnType("int");

                    b.Property<int?>("YilID")
                        .HasColumnType("int");

                    b.HasKey("AracOzellikID");

                    b.HasIndex("AracMarkaID");

                    b.HasIndex("AracModelID");

                    b.ToTable("AracOzellik");
                });

            modelBuilder.Entity("AracIhale.API.DTO.Araclar", b =>
                {
                    b.Property<int>("AracID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Aciklama")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("AracFiyati")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("AracOzellikID")
                        .HasColumnType("int");

                    b.Property<int?>("BireyselKurumsalID")
                        .HasColumnType("int");

                    b.Property<string>("Donanim")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("Gorsel1")
                        .HasMaxLength(50)
                        .HasColumnType("varbinary(50)");

                    b.Property<byte[]>("Gorsel2")
                        .HasMaxLength(50)
                        .HasColumnType("varbinary(50)");

                    b.Property<byte[]>("Gorsel3")
                        .HasMaxLength(50)
                        .HasColumnType("varbinary(50)");

                    b.Property<byte[]>("Gorsel4")
                        .HasMaxLength(50)
                        .HasColumnType("varbinary(50)");

                    b.Property<byte[]>("Gorsel5")
                        .HasMaxLength(50)
                        .HasColumnType("varbinary(50)");

                    b.Property<string>("KMBilgisi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<string>("KurumsalSirketAdi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Plaka")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("StatuID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("AracID");

                    b.HasIndex("AracOzellikID");

                    b.HasIndex("BireyselKurumsalID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("Araclar");
                });

            modelBuilder.Entity("AracIhale.API.DTO.BireyselAracTeklif", b =>
                {
                    b.Property<int>("TeklifID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("IhaleID")
                        .HasColumnType("int");

                    b.Property<int?>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<string>("TeklifFiyati")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("TeklifTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("TeklifID");

                    b.HasIndex("IhaleID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("BireyselAracTeklif");
                });

            modelBuilder.Entity("AracIhale.API.DTO.BireyselKurumsal", b =>
                {
                    b.Property<int>("BireselKurumsalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Durum")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("BireselKurumsalID");

                    b.ToTable("BireyselKurumsal");
                });

            modelBuilder.Entity("AracIhale.API.DTO.IhaleListesi", b =>
                {
                    b.Property<int>("IhaleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AracID")
                        .HasColumnType("int");

                    b.Property<int?>("AracOzellikID")
                        .HasColumnType("int");

                    b.Property<int?>("BireyselKurumsalID")
                        .HasColumnType("int");

                    b.Property<string>("IhaleAdi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IhaleBaslangicFiyati")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IhaleBaslangicSaati")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IhaleBaslangicTarihi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IhaleBitisSaati")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IhaleBitisTarihi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("IhaleStatuID")
                        .HasColumnType("int");

                    b.Property<string>("KurumsalSirketAdi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MinimumAlimFiyati")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IhaleID");

                    b.HasIndex("AracID");

                    b.HasIndex("AracOzellikID");

                    b.HasIndex("BireyselKurumsalID");

                    b.HasIndex("IhaleStatuID");

                    b.ToTable("IhaleListesi");
                });

            modelBuilder.Entity("AracIhale.API.DTO.IhaleStatu", b =>
                {
                    b.Property<int>("IhaleStatuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("IhaleStatuAdi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IhaleStatuID");

                    b.ToTable("IhaleStatu");
                });

            modelBuilder.Entity("AracIhale.API.DTO.Kullanici", b =>
                {
                    b.Property<int>("KullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("AktifPasifID")
                        .HasColumnType("int");

                    b.Property<int?>("BireyselKurumsalID")
                        .HasColumnType("int");

                    b.Property<string>("FirmaAdi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("FirmaBilgisiID")
                        .HasColumnType("int");

                    b.Property<string>("Fotograf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KurumsalAdres")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("KurumsalIl")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KurumsalIlce")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("RolID")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefon")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("KullaniciID");

                    b.HasIndex("BireyselKurumsalID");

                    b.HasIndex("RolID");

                    b.ToTable("Kullanici");
                });

            modelBuilder.Entity("AracIhale.API.DTO.OnaylananTeklif", b =>
                {
                    b.Property<int>("OnaylananTeklifID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("IhaleID")
                        .HasColumnType("int");

                    b.Property<int?>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OnaylanmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("TeklifFiyati")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TeklifID")
                        .HasColumnType("int");

                    b.HasKey("OnaylananTeklifID");

                    b.HasIndex("IhaleID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("OnaylananTeklif");
                });

            modelBuilder.Entity("AracIhale.API.DTO.Rol", b =>
                {
                    b.Property<int>("RolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("RolAdi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RolID");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("AracIhale.API.DTO.AracModel", b =>
                {
                    b.HasOne("AracIhale.API.DTO.AracMarka", "AracMarka")
                        .WithMany("AracModels")
                        .HasForeignKey("AracMarkaID");

                    b.Navigation("AracMarka");
                });

            modelBuilder.Entity("AracIhale.API.DTO.AracOzellik", b =>
                {
                    b.HasOne("AracIhale.API.DTO.AracMarka", "AracMarka")
                        .WithMany("AracOzelliks")
                        .HasForeignKey("AracMarkaID");

                    b.HasOne("AracIhale.API.DTO.AracModel", "AracModel")
                        .WithMany("AracOzelliks")
                        .HasForeignKey("AracModelID");

                    b.Navigation("AracMarka");

                    b.Navigation("AracModel");
                });

            modelBuilder.Entity("AracIhale.API.DTO.Araclar", b =>
                {
                    b.HasOne("AracIhale.API.DTO.AracOzellik", "AracOzellik")
                        .WithMany("Araclars")
                        .HasForeignKey("AracOzellikID");

                    b.HasOne("AracIhale.API.DTO.BireyselKurumsal", "BireyselKurumsal")
                        .WithMany("Araclars")
                        .HasForeignKey("BireyselKurumsalID");

                    b.HasOne("AracIhale.API.DTO.Kullanici", "Kullanici")
                        .WithMany("Araclars")
                        .HasForeignKey("KullaniciID");

                    b.Navigation("AracOzellik");

                    b.Navigation("BireyselKurumsal");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("AracIhale.API.DTO.BireyselAracTeklif", b =>
                {
                    b.HasOne("AracIhale.API.DTO.IhaleListesi", "IhaleListesi")
                        .WithMany("BireyselAracTeklifs")
                        .HasForeignKey("IhaleID");

                    b.HasOne("AracIhale.API.DTO.Kullanici", "Kullanici")
                        .WithMany("BireyselAracTeklifs")
                        .HasForeignKey("KullaniciID");

                    b.Navigation("IhaleListesi");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("AracIhale.API.DTO.IhaleListesi", b =>
                {
                    b.HasOne("AracIhale.API.DTO.Araclar", "Araclar")
                        .WithMany()
                        .HasForeignKey("AracID");

                    b.HasOne("AracIhale.API.DTO.AracOzellik", "AracOzellik")
                        .WithMany()
                        .HasForeignKey("AracOzellikID");

                    b.HasOne("AracIhale.API.DTO.BireyselKurumsal", "BireyselKurumsal")
                        .WithMany("IhaleListesis")
                        .HasForeignKey("BireyselKurumsalID");

                    b.HasOne("AracIhale.API.DTO.IhaleStatu", "IhaleStatu")
                        .WithMany("IhaleListesis")
                        .HasForeignKey("IhaleStatuID");

                    b.Navigation("Araclar");

                    b.Navigation("AracOzellik");

                    b.Navigation("BireyselKurumsal");

                    b.Navigation("IhaleStatu");
                });

            modelBuilder.Entity("AracIhale.API.DTO.Kullanici", b =>
                {
                    b.HasOne("AracIhale.API.DTO.BireyselKurumsal", "BireyselKurumsal")
                        .WithMany("Kullanicis")
                        .HasForeignKey("BireyselKurumsalID");

                    b.HasOne("AracIhale.API.DTO.Rol", "Rol")
                        .WithMany("Kullanicis")
                        .HasForeignKey("RolID");

                    b.Navigation("BireyselKurumsal");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("AracIhale.API.DTO.OnaylananTeklif", b =>
                {
                    b.HasOne("AracIhale.API.DTO.IhaleListesi", "IhaleListesi")
                        .WithMany("OnaylananTeklifs")
                        .HasForeignKey("IhaleID");

                    b.HasOne("AracIhale.API.DTO.Kullanici", "Kullanici")
                        .WithMany("OnaylananTeklifs")
                        .HasForeignKey("KullaniciID");

                    b.Navigation("IhaleListesi");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("AracIhale.API.DTO.AracMarka", b =>
                {
                    b.Navigation("AracModels");

                    b.Navigation("AracOzelliks");
                });

            modelBuilder.Entity("AracIhale.API.DTO.AracModel", b =>
                {
                    b.Navigation("AracOzelliks");
                });

            modelBuilder.Entity("AracIhale.API.DTO.AracOzellik", b =>
                {
                    b.Navigation("Araclars");
                });

            modelBuilder.Entity("AracIhale.API.DTO.BireyselKurumsal", b =>
                {
                    b.Navigation("Araclars");

                    b.Navigation("IhaleListesis");

                    b.Navigation("Kullanicis");
                });

            modelBuilder.Entity("AracIhale.API.DTO.IhaleListesi", b =>
                {
                    b.Navigation("BireyselAracTeklifs");

                    b.Navigation("OnaylananTeklifs");
                });

            modelBuilder.Entity("AracIhale.API.DTO.IhaleStatu", b =>
                {
                    b.Navigation("IhaleListesis");
                });

            modelBuilder.Entity("AracIhale.API.DTO.Kullanici", b =>
                {
                    b.Navigation("Araclars");

                    b.Navigation("BireyselAracTeklifs");

                    b.Navigation("OnaylananTeklifs");
                });

            modelBuilder.Entity("AracIhale.API.DTO.Rol", b =>
                {
                    b.Navigation("Kullanicis");
                });
#pragma warning restore 612, 618
        }
    }
}
