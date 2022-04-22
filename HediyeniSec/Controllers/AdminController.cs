using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HediyeniSec.Models.Siniflar;

namespace HediyeniSec.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.IcimdenGeldis.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniFikir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniFikir(IcimdenGeldi f)
        {
            c.IcimdenGeldis.Add(f);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult FikirSil(int id)
        {
            var f = c.IcimdenGeldis.Find(id);
            c.IcimdenGeldis.Remove(f);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult FikirGetir(int id)
        {
            var fik = c.IcimdenGeldis.Find(id);
            return View("FikirGetir", fik);
        }
        public ActionResult FikirGuncelle(IcimdenGeldi f)
        {
            var fkr = c.IcimdenGeldis.Find(f.ID);
            fkr.Aciklama = f.Aciklama;
            fkr.Baslik = f.Baslik;
            fkr.Image = f.Image;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var f = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(f);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yrm = c.Yorumlars.Find(id);
            return View("YorumGetir", yrm);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrum = c.Yorumlars.Find(y.ID);
            yrum.KullaniciAdi = y.KullaniciAdi;           
            yrum.Mail = y.Mail;           
            yrum.Yorum = y.Yorum;           
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        
    }
}