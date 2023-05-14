using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class PaketTanimlama
    {
        public PaketTanimlama()
        {
            KurumsalUyeOnays = new HashSet<KurumsalUyeOnay>();
            PaketParametres = new HashSet<PaketParametre>();
        }

        public int PaketId { get; set; }
        public string PaketAdi { get; set; }

        public virtual ICollection<KurumsalUyeOnay> KurumsalUyeOnays { get; set; }
        public virtual ICollection<PaketParametre> PaketParametres { get; set; }
    }
}
