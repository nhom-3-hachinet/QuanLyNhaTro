using System.Web.Mvc;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using NhaTro.Models;
namespace NhaTro.Controllers
{
    public class NguoiDungController : Controller
    {
        QuanLyNhaTroDbContext db = new QuanLyNhaTroDbContext();
        // GET: NguoiDung
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Dangky()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dangky(KhachHang kh)
        {// chen du lieu vao bang khachang
            db.KhachHangs.Add(kh);
            //save in database
            db.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult Dangnhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dangnhap(FormCollection f)
        {
            string staikhoan = f["txtTaikhoan"].ToString();
            string smatkhau = f["txtMatKhau"].ToString();
            KhachHang kh = db.KhachHangs.SingleOrDefault(n => n.TaiKhoan == staikhoan && n.MatKhau == smatkhau);
            if (kh != null)
            {
                ViewBag.thongbao = "chuc mung ban dang nhap thanh cong!";
                Session["TaiKhoan"] = kh;
                return RedirectToAction("Index", "Home");
                //return View();
            }
            ViewBag.thongbao = "Tên tài khoản hoặc mật khẩu không đúng !";
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Dangnhap", "NguoiDung");
        }




    }
}
