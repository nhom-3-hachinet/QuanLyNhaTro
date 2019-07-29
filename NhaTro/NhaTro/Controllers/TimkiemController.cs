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
        [HttpPost]
        public ActionResult KetQuaTimKiem(FormCollection f)
        {
            string sTuKhoa = f["txtTimKiem"].ToString();

            var model = (from a in db.BaiDangs
                         join b in db.QuanHuyens on a.MaQH equals b.MaQH
                         join c in db.TinhTPs on a.MaTTP equals c.MaTTP
                         where a.TieuDe.Contains(sTuKhoa)
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
            List<BaiDangDAO> ListKQTK = model.ToList();
             if(ListKQTK.Count == 0)
            {
                ViewBag.ThongBao = "Không tìm thấy kết quả nào";
            }
            ViewBag.ThongBao = "Đã tìm thấy " + ListKQTK.Count + " kết quả !";
            return View(model.ToList());
        }
    }
}