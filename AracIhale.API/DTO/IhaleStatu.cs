using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AracIhale.API.DTO
{
	public class IhaleStatu
	{
		public IhaleStatu()
		{
			IhaleListesis = new HashSet<IhaleListesi>();
		}

		public int IhaleStatuID { get; set; }

		[StringLength(50)]
		public string IhaleStatuAdi { get; set; }

		public virtual ICollection<IhaleListesi> IhaleListesis { get; set; }
	}
}
