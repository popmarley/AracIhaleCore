using AracIhale.Entity.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.DAL.VM
{
    public class IhaleVM
    {
        public int AracID { get; set; }

        public string MinimumalisFiyati { get; set; }
        public string IhaleBaslangicFiyati { get; set; }
        public Araclar Fiyat { get; set; }
        public int IhaleID { get; set; }
        public int AracMarkaID { get; set; }
        public int KullaniciID { get; set; }
        public int AracModelID { get; set; }
        public SelectList BireyselKurumsalList { get; set; }

        public SelectList Ihalelistesi { get; set; }
        public SelectList StatuList { get; set; }

        public List<IhaleListesi> Ihalelister { get; set; }
        public string IhaleIsim { get; set; }
        public string IhaleStatuAdi { get; set; }
        public string BireyselKurumsal { get; set; }

        public int? BireyselKurumsalID { get; set; }
        public string KurumsalSirketAdi { get; set; }
        public int? IhaleStatuID { get; set; }
        public DateTime? IhaleBaslangicTarihi { get; set; }
        public DateTime? IhaleBaslangicSaati { get; set; }
        public DateTime? IhaleBitisTarihi { get; set; }
        public DateTime? IhaleBitisSaati { get; set; }
        public DateTime? Tarih { get; set; } = DateTime.Now;
    }
}
