﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AracIhale.API.DTO
{
	public class OnaylananTeklif
	{
		public int OnaylananTeklifID { get; set; }

		public int? TeklifID { get; set; }

		public int? KullaniciID { get; set; }

		public int? IhaleID { get; set; }

		public DateTime? OnaylanmaTarihi { get; set; }

		[StringLength(50)]
		public string TeklifFiyati { get; set; }

		public virtual BireyselAracTeklif BireyselAracTeklif { get; set; }

		public virtual IhaleListesi IhaleListesi { get; set; }

		public virtual Kullanici Kullanici { get; set; }
	}
}
