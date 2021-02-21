using Egitim.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Egitim.Entities.Concrete
{
    public class Okul:IEntity
    {
        public Okul()
        {
            Ogretmenler = new List<Ogretmen>();
            Yorumlar = new List<OkulYorum>();
        }

        public int Id { get; set; } 
        public string OkulAdi { get; set; }
        public string OkulAciklama { get; set; }
        public decimal OkulPuan { get; set; }
        public string FotoBaglantisi { get; set; }


        public virtual ICollection<Ogretmen> Ogretmenler { get; set; }
        public virtual ICollection<OkulYorum> Yorumlar { get; set; }
    }
}
