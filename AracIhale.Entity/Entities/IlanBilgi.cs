using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class IlanBilgi
    {
        public int IlanId { get; set; }
        public int? AracId { get; set; }
        public string IlanBasligi { get; set; }
        public string IlanAciklamasi { get; set; }

        public virtual Araclar Arac { get; set; }
    }
}
