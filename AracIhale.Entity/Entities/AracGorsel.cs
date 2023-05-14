using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class AracGorsel
    {
        public AracGorsel()
        {
            Araclars = new HashSet<Araclar>();
        }

        public int AracGorselId { get; set; }
        public string Gorsel { get; set; }

        public virtual ICollection<Araclar> Araclars { get; set; }
    }
}
