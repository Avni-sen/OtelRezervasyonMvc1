using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelRezervasyonMvc.Models.Entity;
namespace OtelRezervasyonMvc.Controllers
{
    public class İletisimController : Controller
    {
        DbOtelEntities db = new DbOtelEntities();
        // GET: İletisim
        public ActionResult Index()
        {
            var veriler = db.Tbl_İletisim.ToList();
            return View(veriler);
        }

        public PartialViewResult mesajGonder(Tbl_Mesajlar msg)
        {
            db.Tbl_Mesajlar.Add(msg);
            db.SaveChanges();
            return PartialView();
        }
    }
}