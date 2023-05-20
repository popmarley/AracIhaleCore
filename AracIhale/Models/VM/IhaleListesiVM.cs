﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AracIhale.UI.Models.VM
{
    public class IhaleListesiVM
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
		public string IhaleBaslangicTarihi { get; set; }
		[StringLength(75)]
		public string IhaleBaslangicSaati { get; set; }
		[StringLength(75)]
		public string IhaleBitisTarihi { get; set; }
		[StringLength(75)]
		public string IhaleBitisSaati { get; set; }

		public int AracID { get; set; }
		[StringLength(75)]
		public string IhaleBaslangicFiyati { get; set; } = "";
		[StringLength(75)]
		public string MinimumAlimFiyati { get; set; } = "";

        public int? AracOzellikID { get; set; }

        public virtual Araclar Araclar { get; set; }

        public virtual AracOzellik AracOzellik { get; set; }

        public virtual BireyselKurumsal BireyselKurumsal { get; set; }

        public virtual IhaleStatu IhaleStatu { get; set; }
        public virtual ICollection<BireyselAracTeklif> BireyselAracTeklifs { get; set; }

        public virtual ICollection<OnaylananTeklifVM> OnaylananTeklifs { get; set; }

        public virtual Kullanici Kullanici { get; set; }
     
    }
}
