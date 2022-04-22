using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace HediyeniSec.Models.Siniflar
{
    public class ArkadasYorum
    {
        public IEnumerable<IcimdenGeldi> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<IcimdenGeldi> Deger3 { get; set; }

    }
}