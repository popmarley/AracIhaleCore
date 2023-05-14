using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class IhaleListesi
    {
        public IhaleListesi()
        {
            IhaleAracs = new HashSet<IhaleArac>();
            OdemeBilgisis = new HashSet<OdemeBilgisi>();
        }

        public int IhaleId { get; set; }
        public string IhaleAdi { get; set; }
        public int? BireyselKurumsalId { get; set; }
        public string KurumsalSirketAdi { get; set; }
        public int? IhaleStatuId { get; set; }
        public DateTime? IhaleBaslangicTarihi { get; set; }
        public DateTime? IhaleBaslangicSaati { get; set; }
        public DateTime? IhaleBitisTarihi { get; set; }
        public DateTime? IhaleBitisSaati { get; set; }
        public DateTime? Tarih { get; set; }

        public virtual BireyselKurumsal BireyselKurumsal { get; set; }
        public virtual IhaleStatu IhaleStatu { get; set; }
        public virtual ICollection<IhaleArac> IhaleAracs { get; set; }
        public virtual ICollection<OdemeBilgisi> OdemeBilgisis { get; set; }
    }
}
