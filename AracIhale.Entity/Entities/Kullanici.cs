using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class Kullanici
    {
        public Kullanici()
        {
            AracAliciBilgis = new HashSet<AracAliciBilgi>();
            AracKullanicis = new HashSet<AracKullanici>();
            Araclars = new HashSet<Araclar>();
            BireyselAracTeklifs = new HashSet<BireyselAracTeklif>();
            Giris = new HashSet<Giri>();
            IhaleAracs = new HashSet<IhaleArac>();
            KurumsalUyeOnays = new HashSet<KurumsalUyeOnay>();
            OdemeBilgisis = new HashSet<OdemeBilgisi>();
        }

        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Ad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public int? AktifPasifId { get; set; }
        public string Sifre { get; set; }
        public int? RolId { get; set; }
        public int? BireyselKurumsalId { get; set; }

        public virtual AktifPasif AktifPasif { get; set; }
        public virtual BireyselKurumsal BireyselKurumsal { get; set; }
        public virtual Rol Rol { get; set; }
        public virtual ICollection<AracAliciBilgi> AracAliciBilgis { get; set; }
        public virtual ICollection<AracKullanici> AracKullanicis { get; set; }
        public virtual ICollection<Araclar> Araclars { get; set; }
        public virtual ICollection<BireyselAracTeklif> BireyselAracTeklifs { get; set; }
        public virtual ICollection<Giri> Giris { get; set; }
        public virtual ICollection<IhaleArac> IhaleAracs { get; set; }
        public virtual ICollection<KurumsalUyeOnay> KurumsalUyeOnays { get; set; }
        public virtual ICollection<OdemeBilgisi> OdemeBilgisis { get; set; }
    }
}
