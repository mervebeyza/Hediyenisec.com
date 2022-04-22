using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HediyeniSec.Models.Siniflar
{
    public class IcimdenGeldi
    { 
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Image { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}