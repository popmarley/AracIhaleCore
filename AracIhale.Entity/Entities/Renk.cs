using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class Renk
    {
        public Renk()
        {
            AracOzelliks = new HashSet<AracOzellik>();
        }

        public int RenkId { get; set; }
        public string RenkAdi { get; set; }

        public virtual ICollection<AracOzellik> AracOzelliks { get; set; }
    }
}
