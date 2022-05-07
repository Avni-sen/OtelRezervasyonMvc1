using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelRezervasyonMvc.Models.Entity;

namespace OtelRezervasyonMvc.Controllers
{
    public class DefaultController : Controller
    {

        DbOtelEntities db = new DbOtelEntities();

        public ActionResult Hakkimda()
        {
            var veriler = db.Tbl_Hakkimda.ToList();
            return View(veriler);
        }
        public PartialViewResult Ekibimiz()
        {
            var ekipList = db.Tbl_Ekibimiz.ToList();
            return PartialView(ekipList);
        }

        public PartialViewResult Istatistik()
        {
            return PartialView();
        }
        public PartialViewResult Referans()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            var doluOda = db.Tbl_Oda.Where(x => x.Durum != 1).Count();
            var bosOda = db.Tbl_Oda.Where(x => x.Durum == 1).Count();
            ViewBag.d = doluOda;
            ViewBag.b = bosOda;
            return PartialView();
        }

        public PartialViewResult PartialSosyalMedya()
        {
            return PartialView();
        }


    }
}