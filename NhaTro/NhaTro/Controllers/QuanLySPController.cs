﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NhaTro.Models;

namespace NhaTro.Controllers
{
    public class QuanLySPController : Controller
    {
        // GET: QuanLySP
        QuanLyNhaTroDbContext db = new QuanLyNhaTroDbContext();
        public ActionResult Index()
        {
            return View(db.);
        }
    }
}