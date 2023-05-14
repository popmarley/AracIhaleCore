using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class Yetki
    {
        public int YetkiId { get; set; }
        public int? RolId { get; set; }
        public string EkranAdi { get; set; }
        public string İslemAdi { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
