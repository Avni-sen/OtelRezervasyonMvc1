using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelRezervasyonMvc.Models.Entity;

namespace OtelRezervasyonMvc.Controllers
{
    [Authorize]
    public class RezervasyonController : Controller
    {
        DbOtelEntities db = new DbOtelEntities();

        // GET: Rezervasyon
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Tbl_OnRezervasyon p)
        {
            var misafirMail = (string)Session["Mail"];
            // var misafirId = db.Tbl_YeniKayit.Where(x => x.Mail == misafirMail).Select(x=>x.ID).FirstOrDefault();
            // p.Durum = 15;
            // p.Misafir = misafirId;
            p.Mail = misafirMail;
            p.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tbl_OnRezervasyon.Add(p);
            db.SaveChanges();
            return RedirectToAction("Rezervasyonlarim" , "Misafir");
        }

        //mesaj detay kısmının aynısı
        public ActionResult RezervasyonDetay(int id)
        {
            var rezervasyon = db.Tbl_OnRezervasyon.Where(x => x.Id == id).FirstOrDefault();
            return View(rezervasyon);
        }
    }
}