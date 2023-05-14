using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class AracParcaBilgi
    {
        public int ParcaId { get; set; }
        public int? AracId { get; set; }
        public string ParcaAdi { get; set; }
        public int? AracParcaDurumId { get; set; }

        public virtual Araclar Arac { get; set; }
        public virtual AracParcaDurumu AracParcaDurum { get; set; }
    }
}
