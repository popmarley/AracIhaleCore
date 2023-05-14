using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class AracTarihce
    {
        public int TarihceId { get; set; }
        public int? AracId { get; set; }
        public string Statu { get; set; }
        public DateTime? Tarih { get; set; }

        public virtual Araclar Arac { get; set; }
    }
}
