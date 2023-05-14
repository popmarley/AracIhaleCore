﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AracIhale.API.DTO
{
	public class BireyselKurumsal
	{
		public BireyselKurumsal()
		{
			Araclars = new HashSet<Araclar>();
			IhaleListesis = new HashSet<IhaleListesi>();
			Kullanicis = new HashSet<Kullanici>();
		}

		[Key]
		public int BireselKurumsalID { get; set; }

		[StringLength(50)]
		public string Durum { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Araclar> Araclars { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<IhaleListesi> IhaleListesis { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Kullanici> Kullanicis { get; set; }
	}
}
