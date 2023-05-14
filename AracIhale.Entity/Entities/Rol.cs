using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class Rol
    {
        public Rol()
        {
            Giris = new HashSet<Giri>();
            Kullanicis = new HashSet<Kullanici>();
            RolMenus = new HashSet<RolMenu>();
            Yetkis = new HashSet<Yetki>();
        }

        public int RolId { get; set; }
        public string RolAdi { get; set; }

        public virtual ICollection<Giri> Giris { get; set; }
        public virtual ICollection<Kullanici> Kullanicis { get; set; }
        public virtual ICollection<RolMenu> RolMenus { get; set; }
        public virtual ICollection<Yetki> Yetkis { get; set; }
    }
}
