using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhale.Entity.Entities
{
    public partial class Menu
    {
        public Menu()
        {
            RolMenus = new HashSet<RolMenu>();
        }

        public int MenuId { get; set; }
        public string MenuIsım { get; set; }
        public bool? AktifMi { get; set; }

        public virtual ICollection<RolMenu> RolMenus { get; set; }
    }
}
