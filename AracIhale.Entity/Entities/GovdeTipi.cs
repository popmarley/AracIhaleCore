using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class GovdeTipi
    {
        public GovdeTipi()
        {
            AracOzelliks = new HashSet<AracOzellik>();
        }

        public int GovdeTipiId { get; set; }
        public string GovdeTipiAdi { get; set; }

        public virtual ICollection<AracOzellik> AracOzelliks { get; set; }
    }
}
