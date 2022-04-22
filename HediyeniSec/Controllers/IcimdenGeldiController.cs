using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HediyeniSec.Models.Siniflar;



namespace HediyeniSec.Controllers
{
    public class IcimdenGeldiController : Controller
    {
        Context c = new Context();
        ArkadasYorum ay = new ArkadasYorum();
        public ActionResult Index() 
        {           
            ay.Deger1 = c.IcimdenGeldis.ToList();
            ay.Deger3 = c.IcimdenGeldis.OrderByDescending(x => x.ID).Take(5).ToList(); 
            return View(ay);
        }
        
        public ActionResult ArkadasDetay(int id)
        {
            ay.Deger1 = c.IcimdenGeldis.Where(x => x.ID == id).ToList();
            ay.Deger2 = c.Yorumlars.Where(x => x.IcimdenGeldiid == id).ToList();
            return View(ay);
        }  
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
  
        [HttpPost]
       public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}