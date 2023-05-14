using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class AktifPasif
    {
        public AktifPasif()
        {
            Kullanicis = new HashSet<Kullanici>();
        }

        public int AktifPasifId { get; set; }
        public string Durumu { get; set; }

        public virtual ICollection<Kullanici> Kullanicis { get; set; }
    }
}
