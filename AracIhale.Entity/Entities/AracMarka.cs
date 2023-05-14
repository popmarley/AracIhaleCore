using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class AracMarka
    {
        public AracMarka()
        {
            AracModels = new HashSet<AracModel>();
            AracOzelliks = new HashSet<AracOzellik>();
        }

        public int AracMarkaId { get; set; }
        public string MarkaAdi { get; set; }

        public virtual ICollection<AracModel> AracModels { get; set; }
        public virtual ICollection<AracOzellik> AracOzelliks { get; set; }
    }
}
