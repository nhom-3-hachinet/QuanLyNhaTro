using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NhaTro.Models;

namespace NhaTro.Controllers
{
    public class TimkiemController : Controller
    {
        // GET: Timkiem
        QuanLyNhaTroDbContext db = new QuanLyNhaTroDbContext();
        public ActionResult KetQuaTimKiem(FormCollection f)
        {
            string sTuKhoa = f["txtTimKiem"].ToString();

            return View();
        }
    }
}