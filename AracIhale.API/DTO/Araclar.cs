using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace AracIhale.API.DTO
{
	public class Araclar
	{
		public Araclar()
		{
			//AracAliciBilgis = new HashSet<AracAliciBilgi>();
			//AracParcaBilgis = new HashSet<AracParcaBilgi>();
			//AracTarihces = new HashSet<AracTarihce>();
			IhaleListesis = new HashSet<IhaleListesi>();
			//IlanBilgis = new HashSet<IlanBilgi>();
			//TramerTutaris = new HashSet<TramerTutari>();
		}

		[Key]
		public int AracID { get; set; }

		public int? BireyselKurumsalID { get; set; }

		[StringLength(50)]
		public string KurumsalSirketAdi { get; set; }

		public int? StatuID { get; set; }

		[StringLength(50)]
		public string AracFiyati { get; set; }

		public int? AracOzellikID { get; set; }

		[StringLength(50)]
		public string KMBilgisi { get; set; }

		[StringLength(50)]
		public string Donanim { get; set; }

		[MaxLength(50)]
		public byte[] Gorsel1 { get; set; }

		[MaxLength(50)]
		public byte[] Gorsel2 { get; set; }

		[MaxLength(50)]
		public byte[] Gorsel3 { get; set; }

		[MaxLength(50)]
		public byte[] Gorsel4 { get; set; }

		[MaxLength(50)]
		public byte[] Gorsel5 { get; set; }

		public DateTime? Tarih { get; set; }

		public int? KullaniciID { get; set; }

		[StringLength(250)]
		public string Aciklama { get; set; }

		[StringLength(50)]
		public string Plaka { get; set; }

		//public virtual ICollection<AracAliciBilgi> AracAliciBilgis { get; set; }

		public virtual AracOzellik AracOzellik { get; set; }

		public virtual BireyselKurumsal BireyselKurumsal { get; set; }

		public virtual Kullanici Kullanici { get; set; }

		//public virtual Statu Statu { get; set; }


		//public virtual ICollection<AracParcaBilgi> AracParcaBilgis { get; set; }


		//public virtual ICollection<AracTarihce> AracTarihces { get; set; }


		public virtual ICollection<IhaleListesi> IhaleListesis { get; set; }


		//public virtual ICollection<IlanBilgi> IlanBilgis { get; set; }


		//public virtual ICollection<TramerTutari> TramerTutaris { get; set; }
	}
}
