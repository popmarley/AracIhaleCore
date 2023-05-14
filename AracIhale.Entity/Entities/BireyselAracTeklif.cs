using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class BireyselAracTeklif
    {
        public int TeklifId { get; set; }
        public int? KullaniciId { get; set; }
        public int? IhaleAracId { get; set; }
        public string TeklifFiyati { get; set; }
        public string TeklifTarihi { get; set; }

        public virtual IhaleArac IhaleArac { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
