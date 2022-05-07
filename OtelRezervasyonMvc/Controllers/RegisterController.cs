using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelRezervasyonMvc.Models.Entity;

namespace OtelRezervasyonMvc.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        DbOtelEntities db = new DbOtelEntities();
        
        [HttpGet]
        public ActionResult KayitOl()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KayitOl(Tbl_YeniKayit kayit)
        {
            db.Tbl_YeniKayit.Add(kayit);
            db.SaveChanges();
            return RedirectToAction("Index","Login");
        }
    }
}