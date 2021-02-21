using Egitim.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Egitim.Entities.Concrete
{
    public class Ogretmen:IEntity
    {

        public Ogretmen()
        {
            Yorumlar = new List<OgretmenYorum>();
        }

        public int Id { get; set; }
        public string OgretmenAdSoyad { get; set; }
        public string OgretmenBrans { get; set; }
        public string OgretmenAciklama { get; set; }
        public decimal OgretmenPuan { get; set; }
        public string FotoBaglantisi { get; set; }
        public string OgretmenPozisyon { get; set; }
        public int OkulId { get; set; }

        public virtual Okul Okulu { get; set; }
        public virtual ICollection<OgretmenYorum> Yorumlar { get; set; }
    }
}
