using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AracIhale.API.DTO
{
    public class AracModel
    {
        public AracModel()
        {
            AracOzelliks = new HashSet<AracOzellik>();
        }

        public int AracModelID { get; set; }

        [StringLength(50)]
        public string ModelAdi { get; set; }

        public int? AracMarkaID { get; set; }

        public virtual AracMarka AracMarka { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracOzellik> AracOzelliks { get; set; }
    }
}
