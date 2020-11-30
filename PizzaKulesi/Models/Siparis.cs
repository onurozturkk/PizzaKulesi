using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKulesi.Models
{
    public class Siparis
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int PizzaId { get; set; }
        public bool TeslimDurumu { get; set; }
        public string VirgulluMalzeme
        {
            get
            {
                return $"({EkstraMalzemeler.Select(x => x.MalzemeAd).Virgulle()})";
            }

        }

        public virtual Musteri Musteri { get; set; }
        public virtual Pizza Pizza { get; set; }
        public virtual ICollection<EkstraMalzeme> EkstraMalzemeler { get; set; }

        public string AdresiYaz { get { return Musteri.Adres; } }
    }
}
