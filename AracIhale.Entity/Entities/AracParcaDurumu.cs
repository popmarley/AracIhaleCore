using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class AracParcaDurumu
    {
        public AracParcaDurumu()
        {
            AracParcaBilgis = new HashSet<AracParcaBilgi>();
        }

        public int AracParcaDurumId { get; set; }
        public string DurumAdi { get; set; }

        public virtual ICollection<AracParcaBilgi> AracParcaBilgis { get; set; }
    }
}
