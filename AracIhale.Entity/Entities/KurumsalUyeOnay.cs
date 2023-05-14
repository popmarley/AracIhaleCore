using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class KurumsalUyeOnay
    {
        public int OnayId { get; set; }
        public int? KullaniciId { get; set; }
        public int? PaketId { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public virtual PaketTanimlama Paket { get; set; }
    }
}
