using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class TramerTutari
    {
        public int TramerId { get; set; }
        public int? AracId { get; set; }
        public string Tutar { get; set; }

        public virtual Araclar Arac { get; set; }
    }
}
