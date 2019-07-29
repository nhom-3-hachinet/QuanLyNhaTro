using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NhaTro.Models;

namespace NhaTro.Controllers
{
    public class QuanLySanPhamController : Controller
    {
        // GET: QuanLySanPham
        QuanLyNhaTroDbContext db = new QuanLyNhaTroDbContext();
        public ActionResult Index()
        {
            return View(db.BaiDangs.ToList());
        }

        public ActionResult ThemMoi()
        {
            NewPostViewModel model = new NewPostViewModel
            {
                MaQH = db.QuanHuyens.ToList(),
                MaTTP = db.TinhTPs.ToList(),
            };
            return View(model);
        }
    }
}