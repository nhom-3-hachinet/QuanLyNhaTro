using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NhaTro.Models;
namespace NhaTro.Models
{
    
    public class BaiDangDAO
    {
        QuanLyNhaTroDbContext db = new QuanLyNhaTroDbContext();
        
        public List<BaiDang> ListBaiDangChinh()
        {
            var model = (from a in db.BaiDangs
                         join b in db.QuanHuyens on a.MaQH equals b.MaQH
                         join c in db.TinhTPs on a.MaTTP equals c.MaTTP
                         where a.Moi == 1
                         select new BaiDang()
                         {
                             TieuDe = a.TieuDe,
                             Gia = a.Gia,
                             DiaChi = a.DiaChi,
                             SDT = a.SDT,
                             //TenQH = b.TenQH,
                             //TenTTP = c.TenTTP
                         });
            return model.ToList();
        }
    }
}