using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class IhaleStatu
    {
        public IhaleStatu()
        {
            IhaleListesis = new HashSet<IhaleListesi>();
        }

        public int IhaleStatuId { get; set; }
        public string IhaleStatuAdi { get; set; }

        public virtual ICollection<IhaleListesi> IhaleListesis { get; set; }
    }
}
