using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class AracIhaleContext : DbContext
    {
        public AracIhaleContext()
        {
        }

        public AracIhaleContext(DbContextOptions<AracIhaleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AktifPasif> AktifPasifs { get; set; }
        public virtual DbSet<AracAliciBilgi> AracAliciBilgis { get; set; }
        public virtual DbSet<AracGorsel> AracGorsels { get; set; }
        public virtual DbSet<AracKullanici> AracKullanicis { get; set; }
        public virtual DbSet<AracMarka> AracMarkas { get; set; }
        public virtual DbSet<AracModel> AracModels { get; set; }
        public virtual DbSet<AracOzellik> AracOzelliks { get; set; }
        public virtual DbSet<AracParcaBilgi> AracParcaBilgis { get; set; }
        public virtual DbSet<AracParcaDurumu> AracParcaDurumus { get; set; }
        public virtual DbSet<AracTarihce> AracTarihces { get; set; }
        public virtual DbSet<Araclar> Araclars { get; set; }
        public virtual DbSet<BireyselAracTeklif> BireyselAracTeklifs { get; set; }
        public virtual DbSet<BireyselKurumsal> BireyselKurumsals { get; set; }
        public virtual DbSet<Giri> Giris { get; set; }
        public virtual DbSet<GovdeTipi> GovdeTipis { get; set; }
        public virtual DbSet<IhaleArac> IhaleAracs { get; set; }
        public virtual DbSet<IhaleListesi> IhaleListesis { get; set; }
        public virtual DbSet<IhaleStatu> IhaleStatus { get; set; }
        public virtual DbSet<IlanBilgi> IlanBilgis { get; set; }
        public virtual DbSet<Kullanici> Kullanicis { get; set; }
        public virtual DbSet<KurumsalUyeOnay> KurumsalUyeOnays { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<OdemeBilgisi> OdemeBilgisis { get; set; }
        public virtual DbSet<PaketParametre> PaketParametres { get; set; }
        public virtual DbSet<PaketTanimlama> PaketTanimlamas { get; set; }
        public virtual DbSet<Renk> Renks { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<RolMenu> RolMenus { get; set; }
        public virtual DbSet<Statu> Status { get; set; }
        public virtual DbSet<TramerTutari> TramerTutaris { get; set; }
        public virtual DbSet<VitesTipi> VitesTipis { get; set; }
        public virtual DbSet<YakitTipi> YakitTipis { get; set; }
        public virtual DbSet<Yetki> Yetkis { get; set; }
        public virtual DbSet<Yil> Yils { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-B159TJH;Database=AracIhale;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AktifPasif>(entity =>
            {
                entity.ToTable("AktifPasif");

                entity.Property(e => e.AktifPasifId).HasColumnName("AktifPasifID");

                entity.Property(e => e.Durumu).HasMaxLength(50);
            });

            modelBuilder.Entity<AracAliciBilgi>(entity =>
            {
                entity.HasKey(e => e.AliciId);

                entity.ToTable("AracAliciBilgi");

                entity.Property(e => e.AliciId).HasColumnName("AliciID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.AracAliciBilgis)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_AracAliciBilgi_Araclar");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.AracAliciBilgis)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK_AracAliciBilgi_Kullanici");
            });

            modelBuilder.Entity<AracGorsel>(entity =>
            {
                entity.ToTable("AracGorsel");

                entity.Property(e => e.AracGorselId).HasColumnName("AracGorselID");

                entity.Property(e => e.Gorsel).IsRequired();
            });

            modelBuilder.Entity<AracKullanici>(entity =>
            {
                entity.ToTable("AracKullanici");

                entity.Property(e => e.AracKullaniciId).HasColumnName("AracKullaniciID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.AracKullanicis)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_AracKullanici_Araclar");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.AracKullanicis)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK_AracKullanici_Kullanici");
            });

            modelBuilder.Entity<AracMarka>(entity =>
            {
                entity.ToTable("AracMarka");

                entity.Property(e => e.AracMarkaId).HasColumnName("AracMarkaID");

                entity.Property(e => e.MarkaAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<AracModel>(entity =>
            {
                entity.ToTable("AracModel");

                entity.Property(e => e.AracModelId).HasColumnName("AracModelID");

                entity.Property(e => e.AracMarkaId).HasColumnName("AracMarkaID");

                entity.Property(e => e.ModelAdi).HasMaxLength(50);

                entity.HasOne(d => d.AracMarka)
                    .WithMany(p => p.AracModels)
                    .HasForeignKey(d => d.AracMarkaId)
                    .HasConstraintName("FK_AracModel_AracMarka");
            });

            modelBuilder.Entity<AracOzellik>(entity =>
            {
                entity.ToTable("AracOzellik");

                entity.Property(e => e.AracOzellikId).HasColumnName("AracOzellikID");

                entity.Property(e => e.AracMarkaId).HasColumnName("AracMarkaID");

                entity.Property(e => e.AracModelId).HasColumnName("AracModelID");

                entity.Property(e => e.GovdeTipiId).HasColumnName("GovdeTipiID");

                entity.Property(e => e.RenkId).HasColumnName("RenkID");

                entity.Property(e => e.VitesTipiId).HasColumnName("VitesTipiID");

                entity.Property(e => e.YakitTipiId).HasColumnName("YakitTipiID");

                entity.Property(e => e.YilId).HasColumnName("YilID");

                entity.HasOne(d => d.AracMarka)
                    .WithMany(p => p.AracOzelliks)
                    .HasForeignKey(d => d.AracMarkaId)
                    .HasConstraintName("FK_AracOzellik_AracMarka");

                entity.HasOne(d => d.AracModel)
                    .WithMany(p => p.AracOzelliks)
                    .HasForeignKey(d => d.AracModelId)
                    .HasConstraintName("FK_AracOzellik_AracModel");

                entity.HasOne(d => d.GovdeTipi)
                    .WithMany(p => p.AracOzelliks)
                    .HasForeignKey(d => d.GovdeTipiId)
                    .HasConstraintName("FK_AracOzellik_GovdeTipi");

                entity.HasOne(d => d.Renk)
                    .WithMany(p => p.AracOzelliks)
                    .HasForeignKey(d => d.RenkId)
                    .HasConstraintName("FK_AracOzellik_Renk");

                entity.HasOne(d => d.VitesTipi)
                    .WithMany(p => p.AracOzelliks)
                    .HasForeignKey(d => d.VitesTipiId)
                    .HasConstraintName("FK_AracOzellik_VitesTipi");

                entity.HasOne(d => d.YakitTipi)
                    .WithMany(p => p.AracOzelliks)
                    .HasForeignKey(d => d.YakitTipiId)
                    .HasConstraintName("FK_AracOzellik_YakitTipi");

                entity.HasOne(d => d.Yil)
                    .WithMany(p => p.AracOzelliks)
                    .HasForeignKey(d => d.YilId)
                    .HasConstraintName("FK_AracOzellik_Yil");
            });

            modelBuilder.Entity<AracParcaBilgi>(entity =>
            {
                entity.HasKey(e => e.ParcaId);

                entity.ToTable("AracParcaBilgi");

                entity.Property(e => e.ParcaId).HasColumnName("ParcaID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.AracParcaDurumId).HasColumnName("AracParcaDurumID");

                entity.Property(e => e.ParcaAdi).HasMaxLength(50);

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.AracParcaBilgis)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_AracParcaBilgi_Araclar");

                entity.HasOne(d => d.AracParcaDurum)
                    .WithMany(p => p.AracParcaBilgis)
                    .HasForeignKey(d => d.AracParcaDurumId)
                    .HasConstraintName("FK_AracParcaBilgi_AracParcaDurumu");
            });

            modelBuilder.Entity<AracParcaDurumu>(entity =>
            {
                entity.HasKey(e => e.AracParcaDurumId);

                entity.ToTable("AracParcaDurumu");

                entity.Property(e => e.AracParcaDurumId).HasColumnName("AracParcaDurumID");

                entity.Property(e => e.DurumAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<AracTarihce>(entity =>
            {
                entity.HasKey(e => e.TarihceId);

                entity.ToTable("AracTarihce");

                entity.Property(e => e.TarihceId).HasColumnName("TarihceID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.Statu).HasMaxLength(50);

                entity.Property(e => e.Tarih)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.AracTarihces)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_AracTarihce_Araclar");
            });

            modelBuilder.Entity<Araclar>(entity =>
            {
                entity.HasKey(e => e.AracId);

                entity.ToTable("Araclar");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.AracFiyati).HasMaxLength(50);

                entity.Property(e => e.AracGorselId).HasColumnName("AracGorselID");

                entity.Property(e => e.AracOzellikId).HasColumnName("AracOzellikID");

                entity.Property(e => e.AracaPlaka).HasMaxLength(50);

                entity.Property(e => e.BireyselKurumsalId).HasColumnName("BireyselKurumsalID");

                entity.Property(e => e.Donanim).HasMaxLength(50);

                entity.Property(e => e.Kmbilgisi)
                    .HasMaxLength(50)
                    .HasColumnName("KMBilgisi");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.KurumsalSirketAdi).HasMaxLength(50);

                entity.Property(e => e.StatuId).HasColumnName("StatuID");

                entity.Property(e => e.Tarih).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AracGorsel)
                    .WithMany(p => p.Araclars)
                    .HasForeignKey(d => d.AracGorselId)
                    .HasConstraintName("FK_Araclar_AracGorsel");

                entity.HasOne(d => d.AracOzellik)
                    .WithMany(p => p.Araclars)
                    .HasForeignKey(d => d.AracOzellikId)
                    .HasConstraintName("FK_Araclar_AracOzellik");

                entity.HasOne(d => d.BireyselKurumsal)
                    .WithMany(p => p.Araclars)
                    .HasForeignKey(d => d.BireyselKurumsalId)
                    .HasConstraintName("FK_Araclar_BireyselKurumsal");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.Araclars)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK_Araclar_Kullanici");

                entity.HasOne(d => d.Statu)
                    .WithMany(p => p.Araclars)
                    .HasForeignKey(d => d.StatuId)
                    .HasConstraintName("FK_Araclar_Statu");
            });

            modelBuilder.Entity<BireyselAracTeklif>(entity =>
            {
                entity.HasKey(e => e.TeklifId);

                entity.ToTable("BireyselAracTeklif");

                entity.Property(e => e.TeklifId).HasColumnName("TeklifID");

                entity.Property(e => e.IhaleAracId).HasColumnName("IhaleAracID");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.TeklifFiyati).HasMaxLength(50);

                entity.Property(e => e.TeklifTarihi).HasMaxLength(50);

                entity.HasOne(d => d.IhaleArac)
                    .WithMany(p => p.BireyselAracTeklifs)
                    .HasForeignKey(d => d.IhaleAracId)
                    .HasConstraintName("FK_BireyselAracTeklif_IhaleArac");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.BireyselAracTeklifs)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK_BireyselAracTeklif_Kullanici");
            });

            modelBuilder.Entity<BireyselKurumsal>(entity =>
            {
                entity.ToTable("BireyselKurumsal");

                entity.Property(e => e.BireyselKurumsalId).HasColumnName("BireyselKurumsalID");

                entity.Property(e => e.Durum).HasMaxLength(50);
            });

            modelBuilder.Entity<Giri>(entity =>
            {
                entity.HasKey(e => e.GirisId)
                    .HasName("PK__Giris__4E4547417888FC72");

                entity.ToTable("Giri");

                entity.Property(e => e.GirisId).HasColumnName("GirisID");

                entity.Property(e => e.GirisZamani).HasColumnType("datetime");

                entity.Property(e => e.KullaniciAdi)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.Giris)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giris_Kullanici");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Giris)
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("FK_Giris_Rol");
            });

            modelBuilder.Entity<GovdeTipi>(entity =>
            {
                entity.ToTable("GovdeTipi");

                entity.Property(e => e.GovdeTipiId).HasColumnName("GovdeTipiID");

                entity.Property(e => e.GovdeTipiAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<IhaleArac>(entity =>
            {
                entity.ToTable("IhaleArac");

                entity.Property(e => e.IhaleAracId).HasColumnName("IhaleAracID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.IhaleBaslangicFiyati).HasMaxLength(50);

                entity.Property(e => e.IhaleId).HasColumnName("IhaleID");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.MinimumAlimFiyati).HasMaxLength(50);

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.IhaleAracs)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_IhaleArac_Araclar");

                entity.HasOne(d => d.Ihale)
                    .WithMany(p => p.IhaleAracs)
                    .HasForeignKey(d => d.IhaleId)
                    .HasConstraintName("FK_IhaleArac_IhaleListesi");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.IhaleAracs)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK_IhaleArac_Kullanici");
            });

            modelBuilder.Entity<IhaleListesi>(entity =>
            {
                entity.HasKey(e => e.IhaleId);

                entity.ToTable("IhaleListesi");

                entity.Property(e => e.IhaleId).HasColumnName("IhaleID");

                entity.Property(e => e.BireyselKurumsalId).HasColumnName("BireyselKurumsalID");

                entity.Property(e => e.IhaleAdi).HasMaxLength(50);

                entity.Property(e => e.IhaleStatuId).HasColumnName("IhaleStatuID");

                entity.Property(e => e.KurumsalSirketAdi).HasMaxLength(50);

                entity.HasOne(d => d.BireyselKurumsal)
                    .WithMany(p => p.IhaleListesis)
                    .HasForeignKey(d => d.BireyselKurumsalId)
                    .HasConstraintName("FK_IhaleListesi_BireyselKurumsal");

                entity.HasOne(d => d.IhaleStatu)
                    .WithMany(p => p.IhaleListesis)
                    .HasForeignKey(d => d.IhaleStatuId)
                    .HasConstraintName("FK_IhaleListesi_IhaleStatu");
            });

            modelBuilder.Entity<IhaleStatu>(entity =>
            {
                entity.ToTable("IhaleStatu");

                entity.Property(e => e.IhaleStatuId).HasColumnName("IhaleStatuID");

                entity.Property(e => e.IhaleStatuAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<IlanBilgi>(entity =>
            {
                entity.HasKey(e => e.IlanId);

                entity.ToTable("IlanBilgi");

                entity.Property(e => e.IlanId).HasColumnName("IlanID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.IlanBasligi).HasMaxLength(50);

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.IlanBilgis)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_IlanBilgi_Araclar");
            });

            modelBuilder.Entity<Kullanici>(entity =>
            {
                entity.ToTable("Kullanici");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AktifPasifId).HasColumnName("AktifPasifID");

                entity.Property(e => e.BireyselKurumsalId).HasColumnName("BireyselKurumsalID");

                entity.Property(e => e.KullaniciAdi).HasMaxLength(50);

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.Property(e => e.Sifre).HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(50);

                entity.HasOne(d => d.AktifPasif)
                    .WithMany(p => p.Kullanicis)
                    .HasForeignKey(d => d.AktifPasifId)
                    .HasConstraintName("FK_Kullanici_AktifPasif");

                entity.HasOne(d => d.BireyselKurumsal)
                    .WithMany(p => p.Kullanicis)
                    .HasForeignKey(d => d.BireyselKurumsalId)
                    .HasConstraintName("FK_Kullanici_BireyselKurumsal");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Kullanicis)
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("FK_Kullanici_Rol");
            });

            modelBuilder.Entity<KurumsalUyeOnay>(entity =>
            {
                entity.HasKey(e => e.OnayId);

                entity.ToTable("KurumsalUyeOnay");

                entity.Property(e => e.OnayId).HasColumnName("OnayID");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.PaketId).HasColumnName("PaketID");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.KurumsalUyeOnays)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK_KurumsalUyeOnay_Kullanici");

                entity.HasOne(d => d.Paket)
                    .WithMany(p => p.KurumsalUyeOnays)
                    .HasForeignKey(d => d.PaketId)
                    .HasConstraintName("FK_KurumsalUyeOnay_PaketTanimlama");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");
            });

            modelBuilder.Entity<OdemeBilgisi>(entity =>
            {
                entity.HasKey(e => e.OdemeId);

                entity.ToTable("OdemeBilgisi");

                entity.Property(e => e.OdemeId).HasColumnName("OdemeID");

                entity.Property(e => e.IhaleId).HasColumnName("IhaleID");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.OdemeDurumu).HasMaxLength(50);

                entity.Property(e => e.OdemeTarihi).HasMaxLength(50);

                entity.Property(e => e.OdemeTipi).HasMaxLength(50);

                entity.Property(e => e.OdemeTutari).HasMaxLength(50);

                entity.HasOne(d => d.Ihale)
                    .WithMany(p => p.OdemeBilgisis)
                    .HasForeignKey(d => d.IhaleId)
                    .HasConstraintName("FK_OdemeBilgisi_IhaleListesi");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.OdemeBilgisis)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK_OdemeBilgisi_Kullanici");
            });

            modelBuilder.Entity<PaketParametre>(entity =>
            {
                entity.HasKey(e => e.ParametreId);

                entity.ToTable("PaketParametre");

                entity.Property(e => e.ParametreId).HasColumnName("ParametreID");

                entity.Property(e => e.AylikAlimYapanKurumsalSirketlerİcinKomisyonTutari).HasMaxLength(50);

                entity.Property(e => e.AylikİhaleyeCikabilecekAracSayisi).HasMaxLength(50);

                entity.Property(e => e.PaketId).HasColumnName("PaketID");

                entity.HasOne(d => d.Paket)
                    .WithMany(p => p.PaketParametres)
                    .HasForeignKey(d => d.PaketId)
                    .HasConstraintName("FK_PaketParametre_PaketTanimlama");
            });

            modelBuilder.Entity<PaketTanimlama>(entity =>
            {
                entity.HasKey(e => e.PaketId);

                entity.ToTable("PaketTanimlama");

                entity.Property(e => e.PaketId).HasColumnName("PaketID");

                entity.Property(e => e.PaketAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<Renk>(entity =>
            {
                entity.ToTable("Renk");

                entity.Property(e => e.RenkId).HasColumnName("RenkID");

                entity.Property(e => e.RenkAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("Rol");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.Property(e => e.RolAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<RolMenu>(entity =>
            {
                entity.ToTable("RolMenu");

                entity.Property(e => e.RolMenuId).HasColumnName("RolMenuID");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.RolMenus)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_RolMenu_Menu");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.RolMenus)
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("FK_RolMenu_Rol");
            });

            modelBuilder.Entity<Statu>(entity =>
            {
                entity.ToTable("Statu");

                entity.Property(e => e.StatuId).HasColumnName("StatuID");

                entity.Property(e => e.StatuAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<TramerTutari>(entity =>
            {
                entity.HasKey(e => e.TramerId);

                entity.ToTable("TramerTutari");

                entity.Property(e => e.TramerId).HasColumnName("TramerID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.Tutar).HasMaxLength(50);

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.TramerTutaris)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_TramerTutari_Araclar");
            });

            modelBuilder.Entity<VitesTipi>(entity =>
            {
                entity.ToTable("VitesTipi");

                entity.Property(e => e.VitesTipiId).HasColumnName("VitesTipiID");

                entity.Property(e => e.VitesTipiAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<YakitTipi>(entity =>
            {
                entity.ToTable("YakitTipi");

                entity.Property(e => e.YakitTipiId).HasColumnName("YakitTipiID");

                entity.Property(e => e.YakitTipiAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<Yetki>(entity =>
            {
                entity.ToTable("Yetki");

                entity.Property(e => e.YetkiId).HasColumnName("YetkiID");

                entity.Property(e => e.EkranAdi).HasMaxLength(50);

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.Property(e => e.İslemAdi).HasMaxLength(50);

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Yetkis)
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("FK_Yetki_Rol");
            });

            modelBuilder.Entity<Yil>(entity =>
            {
                entity.ToTable("Yil");

                entity.Property(e => e.YilId).HasColumnName("YilID");

                entity.Property(e => e.Yil1)
                    .HasMaxLength(50)
                    .HasColumnName("Yil");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
