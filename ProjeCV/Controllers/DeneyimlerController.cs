﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCV.Models.Entity;
using ProjeCV.Models.Sinif;
namespace ProjeCV.Controllers
{
    public class DeneyimlerController : Controller
    {
        // GET: Deneyimler
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger2 = db.TBLEXPERIENCE.ToList();
            return View(cs);
        }
    }
}