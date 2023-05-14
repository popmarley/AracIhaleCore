using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class OdemeBilgisi
    {
        public int OdemeId { get; set; }
        public int? KullaniciId { get; set; }
        public int? IhaleId { get; set; }
        public string OdemeTutari { get; set; }
        public string OdemeTarihi { get; set; }
        public string OdemeTipi { get; set; }
        public string OdemeDurumu { get; set; }

        public virtual IhaleListesi Ihale { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
