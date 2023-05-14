using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class VitesTipi
    {
        public VitesTipi()
        {
            AracOzelliks = new HashSet<AracOzellik>();
        }

        public int VitesTipiId { get; set; }
        public string VitesTipiAdi { get; set; }

        public virtual ICollection<AracOzellik> AracOzelliks { get; set; }
    }
}
