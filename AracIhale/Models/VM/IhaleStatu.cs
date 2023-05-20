using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AracIhale.UI.Models.VM
{
    public class IhaleStatu
    {
        public IhaleStatu()
        {
            IhaleListesis = new HashSet<IhaleListesiVM>();
        }

        public int IhaleStatuID { get; set; }

        [StringLength(50)]
        public string IhaleStatuAdi { get; set; }

        public virtual ICollection<IhaleListesiVM> IhaleListesis { get; set; }
    }
}
