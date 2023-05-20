using System.ComponentModel.DataAnnotations;
using System;

namespace AracIhale.UI.Models.VM
{
    public class OnaylananTeklifVM
    {
        public int OnaylananTeklifID { get; set; }

        public int? TeklifID { get; set; }

        public int? KullaniciID { get; set; }

        public int? IhaleID { get; set; }

        public DateTime? OnaylanmaTarihi { get; set; }

        [StringLength(50)]
        public string TeklifFiyati { get; set; }

        public virtual BireyselAracTeklif BireyselAracTeklif { get; set; }

        public virtual IhaleListesiVM IhaleListesi { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
