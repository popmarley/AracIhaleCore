using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class AracKullanici
    {
        public int AracKullaniciId { get; set; }
        public int? AracId { get; set; }
        public int? KullaniciId { get; set; }

        public virtual Araclar Arac { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
