using Egitim.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Egitim.Entities.Concrete
{
    public class OkulYorum:IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string YorumIcerik { get; set; }
        public decimal Puan { get; set; }

        public int OkulId { get; set; }

        public virtual Okul Okulu { get; set; }
    }
}
