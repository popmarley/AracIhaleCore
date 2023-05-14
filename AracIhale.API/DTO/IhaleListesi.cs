﻿using System.ComponentModel.DataAnnotations;

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
    }
}
