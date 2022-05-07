using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OtelRezervasyonMvc.Models.Entity;

namespace OtelRezervasyonMvc.Controllers
{
    public class LoginController : Controller
    {
        DbOtelEntities db = new DbOtelEntities();
        // GET: Login
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Tbl_YeniKayit giris)
        {
            var bilgiler = db.Tbl_YeniKayit.FirstOrDefault(x => x.Mail == giris.Mail && x.Sifre == giris.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Mail,false);
                Session["Mail"] = bilgiler.Mail.ToString();
                //giris yapsın 
                return RedirectToAction("Index" , "Misafir");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}