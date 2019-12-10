using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCV.Models.Entity;
using ProjeCV.Models.Sinif;
namespace ProjeCV.Controllers
{
    public class KonferansController : Controller
    {
        // GET: Konferans
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger6 = db.TBLAWARDS.ToList();
            return View(cs);
        }
        [HttpGet]
        public ActionResult YeniKonferans()
        {
            return View();
        }



        [HttpPost]
        public ActionResult YeniKonferans(TBLAWARDS p)
        {
            db.TBLAWARDS.Add(p);
            db.SaveChanges();
            return View(p);
        }

        public ActionResult KonferansSil(int id)
        {
            var konferans = db.TBLAWARDS.Find(id);
            db.TBLAWARDS.Remove(konferans);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}