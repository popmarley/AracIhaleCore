using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class Yil
    {
        public Yil()
        {
            AracOzelliks = new HashSet<AracOzellik>();
        }

        public int YilId { get; set; }
        public string Yil1 { get; set; }

        public virtual ICollection<AracOzellik> AracOzelliks { get; set; }
    }
}
