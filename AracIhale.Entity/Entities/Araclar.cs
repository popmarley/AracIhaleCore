using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class Araclar
    {
        public Araclar()
        {
            AracAliciBilgis = new HashSet<AracAliciBilgi>();
            AracKullanicis = new HashSet<AracKullanici>();
            AracParcaBilgis = new HashSet<AracParcaBilgi>();
            AracTarihces = new HashSet<AracTarihce>();
            IhaleAracs = new HashSet<IhaleArac>();
            IlanBilgis = new HashSet<IlanBilgi>();
            TramerTutaris = new HashSet<TramerTutari>();
        }

        public int AracId { get; set; }
        public int? BireyselKurumsalId { get; set; }
        public string KurumsalSirketAdi { get; set; }
        public int? StatuId { get; set; }
        public string AracFiyati { get; set; }
        public string Kmbilgisi { get; set; }
        public string Donanim { get; set; }
        public int? AracGorselId { get; set; }
        public int? AracOzellikId { get; set; }
        public DateTime? Tarih { get; set; }
        public int? KullaniciId { get; set; }
        public string AracaPlaka { get; set; }

        public virtual AracGorsel AracGorsel { get; set; }
        public virtual AracOzellik AracOzellik { get; set; }
        public virtual BireyselKurumsal BireyselKurumsal { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Statu Statu { get; set; }
        public virtual ICollection<AracAliciBilgi> AracAliciBilgis { get; set; }
        public virtual ICollection<AracKullanici> AracKullanicis { get; set; }
        public virtual ICollection<AracParcaBilgi> AracParcaBilgis { get; set; }
        public virtual ICollection<AracTarihce> AracTarihces { get; set; }
        public virtual ICollection<IhaleArac> IhaleAracs { get; set; }
        public virtual ICollection<IlanBilgi> IlanBilgis { get; set; }
        public virtual ICollection<TramerTutari> TramerTutaris { get; set; }
    }
}
