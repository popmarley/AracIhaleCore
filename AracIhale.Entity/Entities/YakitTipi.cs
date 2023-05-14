using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class YakitTipi
    {
        public YakitTipi()
        {
            AracOzelliks = new HashSet<AracOzellik>();
        }

        public int YakitTipiId { get; set; }
        public string YakitTipiAdi { get; set; }

        public virtual ICollection<AracOzellik> AracOzelliks { get; set; }
    }
}
