﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCV.Models.Entity;
using ProjeCV.Models.Sinif;
namespace ProjeCV.Controllers
{
    public class HobilerController : Controller
    {
        // GET: Hobiler
        DbCvEntities db = new DbCvEntities();

        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger5 = db.TBLINTEREST.ToList();
            return View(cs);
        }
        [HttpGet]
        public ActionResult YeniHobi()
        {
            return View();
        }



        [HttpPost]
        public ActionResult YeniHobi(TBLINTEREST p)
        {
            db.TBLINTEREST.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult HobiSil(int id)
        {
            var hobi = db.TBLINTEREST.Find(id);
            db.TBLINTEREST.Remove(hobi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }




        public ActionResult HobiGetir(int id)
        {
            var hobi = db.TBLINTEREST.Find(id);
            return View("HobiGetir", hobi);
        }
        public ActionResult Guncelle(TBLINTEREST p)
        {
            var veriler = db.TBLINTEREST.Find(p.ID);
            veriler.INTEREST = p.INTEREST;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
  