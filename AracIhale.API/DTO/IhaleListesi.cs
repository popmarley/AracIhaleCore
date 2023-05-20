using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AracIhale.API.DTO
{
    public class IhaleListesi
    {
        [Key]
        public int IhaleID { get; set; }

        [StringLength(50)]
        public string IhaleAdi { get; set; }

        public int? BireyselKurumsalID { get; set; }

        [StringLength(50)]
        public string KurumsalSirketAdi { get; set; }

        public int? IhaleStatuID { get; set; }

        [StringLength(50)]
        public string IhaleBaslangicTarihi { get; set; }

        [StringLength(50)]
        public string IhaleBaslangicSaati { get; set; }

        [StringLength(50)]
        public string IhaleBitisTarihi { get; set; }

        [StringLength(50)]
        public string IhaleBitisSaati { get; set; }

        public int? AracID { get; set; }

        [StringLength(50)]
        public string IhaleBaslangicFiyati { get; set; }

        [StringLength(50)]
        public string MinimumAlimFiyati { get; set; }

        public int? AracOzellikID { get; set; }
		
        [ForeignKey("AracID")]
		public virtual Araclar Araclar { get; set; }

		[ForeignKey("AracOzellikID")]
		public virtual AracOzellik AracOzellik { get; set; }

        public virtual BireyselKurumsal BireyselKurumsal { get; set; }

        public virtual IhaleStatu IhaleStatu { get; set; }
        public virtual ICollection<BireyselAracTeklif> BireyselAracTeklifs { get; set; }

		public virtual ICollection<OnaylananTeklif> OnaylananTeklifs { get; set; }

       
    }
}
