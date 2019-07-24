using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NhaTro.Models;

namespace NhaTro.Controllers
{
    public class NhathueController : Controller
    {
        // GET: Nhathue
        QuanLyNhaTroDbContext db = new QuanLyNhaTroDbContext();
        public ActionResult NhathuePartial()
        {
            var listBaiMoi = db.BaiDangs.Take(3).ToList();
            return PartialView(listBaiMoi);
        }
    }
}