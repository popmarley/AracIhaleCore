using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class AracOzellik
    {
        public AracOzellik()
        {
            Araclars = new HashSet<Araclar>();
        }

        public int AracOzellikId { get; set; }
        public int? YilId { get; set; }
        public int? AracModelId { get; set; }
        public int? GovdeTipiId { get; set; }
        public int? YakitTipiId { get; set; }
        public int? VitesTipiId { get; set; }
        public string Versiyon { get; set; }
        public int? RenkId { get; set; }
        public string OpsiyonelDonanim { get; set; }
        public int? AracMarkaId { get; set; }

        public virtual AracMarka AracMarka { get; set; }
        public virtual AracModel AracModel { get; set; }
        public virtual GovdeTipi GovdeTipi { get; set; }
        public virtual Renk Renk { get; set; }
        public virtual VitesTipi VitesTipi { get; set; }
        public virtual YakitTipi YakitTipi { get; set; }
        public virtual Yil Yil { get; set; }
        public virtual ICollection<Araclar> Araclars { get; set; }
    }
}
