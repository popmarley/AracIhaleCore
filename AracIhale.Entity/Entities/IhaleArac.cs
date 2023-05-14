using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class IhaleArac
    {
        public IhaleArac()
        {
            BireyselAracTeklifs = new HashSet<BireyselAracTeklif>();
        }

        public int IhaleAracId { get; set; }
        public int? IhaleId { get; set; }
        public int? AracId { get; set; }
        public string IhaleBaslangicFiyati { get; set; }
        public string MinimumAlimFiyati { get; set; }
        public int? KullaniciId { get; set; }

        public virtual Araclar Arac { get; set; }
        public virtual IhaleListesi Ihale { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual ICollection<BireyselAracTeklif> BireyselAracTeklifs { get; set; }
    }
}
