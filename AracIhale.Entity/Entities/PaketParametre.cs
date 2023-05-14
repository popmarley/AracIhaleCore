using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class PaketParametre
    {
        public int ParametreId { get; set; }
        public int? PaketId { get; set; }
        public string AylikİhaleyeCikabilecekAracSayisi { get; set; }
        public string AylikAlimYapanKurumsalSirketlerİcinKomisyonTutari { get; set; }

        public virtual PaketTanimlama Paket { get; set; }
    }
}
