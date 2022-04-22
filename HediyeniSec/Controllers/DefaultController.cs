﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HediyeniSec.Models.Siniflar;

namespace HediyeniSec.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.IcimdenGeldis.OrderByDescending(x => x.ID).Take(5).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        //public ActionResult Iletisim()
        //{
        //    return View();
        //}
        public PartialViewResult Partial1()
        {
            var degerler = c.IcimdenGeldis.OrderByDescending(x=>x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.IcimdenGeldis.OrderBy(x => x.ID).Take(1)/*Where(x => x.ID == 1)*/.ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.IcimdenGeldis.Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {
            var deger = c.IcimdenGeldis.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = c.IcimdenGeldis.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(deger);
        }
    }
}