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
            var model = (from a in db.BaiDangs
                         join b in db.QuanHuyens on a.MaQH equals b.MaQH
                         join c in db.TinhTPs on a.MaTTP equals c.MaTTP
                         where a.Moi == 1
                         select new BaiDangDAO()
                         {
                             TieuDe = a.TieuDe,
                             Gia = a.Gia,
                             AnhBia = a.AnhBia,
                             DiaChi = a.DiaChi,
                             SDT = a.SDT,
                             TenQH = b.TenQH,
                             TenTTP = c.TenTTP
                         });
            return View(model.ToList());
        }
    }
}