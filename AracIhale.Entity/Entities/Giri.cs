using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class Giri
    {
        public int GirisId { get; set; }
        public int KullaniciId { get; set; }
        public int? RolId { get; set; }
        public string KullaniciAdi { get; set; }
        public DateTime GirisZamani { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
