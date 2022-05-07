using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelRezervasyonMvc.Models.Entity;
namespace OtelRezervasyonMvc.Controllers
{
    public class HizmetlerController : Controller
    {
        DbOtelEntities db = new DbOtelEntities();
        // GET: Hizmetler
        public ActionResult Hizmetler()
        {
            var veriler = db.Tbl_Hizmetlerimiz.ToList();
            return View(veriler);
        }

    }
}