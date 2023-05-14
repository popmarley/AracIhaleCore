using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class AracModel
    {
        public AracModel()
        {
            AracOzelliks = new HashSet<AracOzellik>();
        }

        public int AracModelId { get; set; }
        public string ModelAdi { get; set; }
        public int? AracMarkaId { get; set; }

        public virtual AracMarka AracMarka { get; set; }
        public virtual ICollection<AracOzellik> AracOzelliks { get; set; }
    }
}
