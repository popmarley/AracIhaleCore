using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class BireyselKurumsal
    {
        public BireyselKurumsal()
        {
            Araclars = new HashSet<Araclar>();
            IhaleListesis = new HashSet<IhaleListesi>();
            Kullanicis = new HashSet<Kullanici>();
        }

        public int BireyselKurumsalId { get; set; }
        public string Durum { get; set; }

        public virtual ICollection<Araclar> Araclars { get; set; }
        public virtual ICollection<IhaleListesi> IhaleListesis { get; set; }
        public virtual ICollection<Kullanici> Kullanicis { get; set; }
    }
}
