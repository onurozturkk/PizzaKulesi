using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKulesi.Models
{
    public class Musteri
    {
        public int Id { get; set; }
        [Required]
        public string AdSoyad { get; set; }
        [Required]
        public string Adres { get; set; }
        public virtual ICollection<Siparis> Siparisler { get; set; }

        public override string ToString()
        {
            return AdSoyad;
        }
    }
}
