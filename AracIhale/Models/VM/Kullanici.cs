using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AracIhale.UI.Models.VM
{
	public class Kullanici
	{
        public int KullaniciID { get; set; }

        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [StringLength(50)]
        public string Ad { get; set; }

        [StringLength(50)]
        public string Telefon { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        public int? AktifPasifID { get; set; }

        [StringLength(50)]
        public string Sifre { get; set; }

        public int? RolID { get; set; }

        public string Fotograf { get; set; }

        [StringLength(50)]
        public string KurumsalIl { get; set; }

        [StringLength(50)]
        public string KurumsalIlce { get; set; }

        [StringLength(250)]
        public string KurumsalAdres { get; set; }

        [StringLength(50)]
        public string FirmaAdi { get; set; }

        public int? FirmaBilgisiID { get; set; }

        public int? BireyselKurumsalID { get; set; }

        //public virtual AktifPasif AktifPasif { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AracAliciBilgi> AracAliciBilgis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Araclar> Araclars { get; set; }


        public virtual ICollection<BireyselAracTeklif> BireyselAracTeklifs { get; set; }

        public virtual BireyselKurumsal BireyselKurumsal { get; set; }

        //public virtual FirmaBilgisi FirmaBilgisi { get; set; }

        //public virtual Rol Rol { get; set; }

        public virtual ICollection<OnaylananTeklifVM> OnaylananTeklifs { get; set; }
    }
}
