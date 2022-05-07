using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OtelRezervasyonMvc.Models.Entity;
namespace OtelRezervasyonMvc.Controllers
{
    [Authorize]
    public class MisafirController : Controller
    {
        DbOtelEntities db = new DbOtelEntities();
        // GET: Misafir
       
        public ActionResult Index()
        {
            var misafirMail = (string)Session["Mail"];
            var misafirbilgi = db.Tbl_YeniKayit.Where(x => x.Mail == misafirMail).FirstOrDefault();
            return View(misafirbilgi);
        }

        public ActionResult Rezervasyonlarim()
        {
            //Giriş yapan kişinin tbl_yenikayit tablosundaki ıd değerini çekip rezervasyon tablosundaki ıd ile karşılaştırıp rezervasyonları listeleme işlemi yapılacak
            var misafirMail = (string)Session["Mail"];
            var degerler = db.Tbl_OnRezervasyon.Where(x => x.Mail == misafirMail).ToList();
            //Tbl_OnRezervasyon T = new Tbl_OnRezervasyon();
            return View(degerler);
        }

        public ActionResult MisafirBilgiGüncelle(Tbl_YeniKayit p)
        {
            var misafir = db.Tbl_YeniKayit.Find(p.ID);
            misafir.AdSoyad = p.AdSoyad;
            misafir.Mail = p.Mail;
            misafir.Sifre = p.Sifre;
            misafir.Telefon = p.Telefon;
            misafir.TC = p.TC;
            misafir.Adres = p.Adres;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Anasayfa");
        }

        public ActionResult GelenMesajlar()
        {
            var misafirMail = (string)Session["Mail"];
            var mesajlar = db.Tbl_Mesaj2.Where(x => x.Alici == misafirMail).ToList();
            return View(mesajlar);
        }
        public ActionResult GonderilenMesajlar()
        {
            var misafirMail = (string)Session["Mail"];
            var mesajlar = db.Tbl_Mesaj2.Where(x => x.Gonderen == misafirMail).ToList();
            return View(mesajlar);
        }

        public ActionResult MesajDetay(int id)
        {
            var mesaj = db.Tbl_Mesaj2.Where(x => x.MesajID == id).FirstOrDefault();
            return View(mesaj);
        }

        [HttpGet]
        public ActionResult YeniMesaj()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniMesaj(Tbl_Mesaj2 p)
        {
            var misafirMail = (string)Session["Mail"];
            p.Gonderen = misafirMail;
            p.Alici = "Admin";
            p.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tbl_Mesaj2.Add(p);
            db.SaveChanges();
            return RedirectToAction("GonderilenMesajlar","Misafir");
        }
    }
}