using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class Statu
    {
        public Statu()
        {
            Araclars = new HashSet<Araclar>();
        }

        public int StatuId { get; set; }
        public string StatuAdi { get; set; }

        public virtual ICollection<Araclar> Araclars { get; set; }
    }
}
