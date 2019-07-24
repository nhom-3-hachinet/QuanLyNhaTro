using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NhaTro.Models;

namespace NhaTro.Controllers
{
    
    public class HomeController : Controller
    {
        QuanLyNhaTroDbContext db = new QuanLyNhaTroDbContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}