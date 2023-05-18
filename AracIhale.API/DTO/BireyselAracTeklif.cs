using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AracIhale.API.DTO
{
    public class BireyselAracTeklif
    {
        [Key]
        public int TeklifID { get; set; }

        public int? KullaniciID { get; set; }

        [StringLength(50)]
        public string TeklifFiyati { get; set; }

        public DateTime? TeklifTarihi { get; set; }

        public int? IhaleID { get; set; }
        
        [ForeignKey("IhaleID")]
        public virtual IhaleListesi IhaleListesi { get; set; }

		[ForeignKey("KullaniciID")]
		public virtual Kullanici Kullanici { get; set; }

		public virtual ICollection<OnaylananTeklif> OnaylananTeklifs { get; set; }
	}
}
