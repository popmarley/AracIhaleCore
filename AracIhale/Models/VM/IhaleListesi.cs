using System;
using System.ComponentModel.DataAnnotations;

namespace AracIhale.UI.Models.VM
{
    public class IhaleListesi
    {
        [Key]
        public int IhaleID { get; set; }

        [StringLength(75)]
        public string IhaleAdi { get; set; } = "";


        public int BireyselKurumsalID { get; set; }

        [StringLength(50)]
        public string KurumsalSirketAdi { get; set; } = "";


        public int IhaleStatuID { get; set; }
        [StringLength(75)]
        public DateTime IhaleBaslangicTarihi { get; set; }
        [StringLength(75)]
        public DateTime IhaleBaslangicSaati { get; set; }
        [StringLength(75)]
        public DateTime IhaleBitisTarihi { get; set; }
        [StringLength(75)]
        public DateTime IhaleBitisSaati { get; set; }

        public int AracID { get; set; }
        [StringLength(75)]
        public string IhaleBaslangicFiyati { get; set; } = "";
        [StringLength(75)]
        public string MinimumAlimFiyati { get; set; } = "";

    }
}
