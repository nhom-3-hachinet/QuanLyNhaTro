using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NhaTro.Models;
using PagedList;
using PagedList.Mvc;

namespace NhaTro.Controllers
{
    public class QuanLySanPhamController : Controller
    {
        // GET: QuanLySanPham
        QuanLyNhaTroDbContext db = new QuanLyNhaTroDbContext();
        public ActionResult Index(int ? page)
        {
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(db.BaiDangs.ToList().OrderBy(n=>n.Gia).ToPagedList(pageNumber,pageSize));
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