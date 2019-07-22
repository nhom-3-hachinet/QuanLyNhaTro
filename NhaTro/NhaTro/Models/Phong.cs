using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NhaTro.Models
{
    public class Phong
    {
        [Key]
        [StringLength(8)]
        public string MaPhong { get; set; }
        public int SoPhong { get; set; }

        public decimal DienTich { get; set; }
        [StringLength(300)]
        public string DiaChi { get; set; }
        public string MaTTP { get; set; }
        public string MaQH { get; set; }
        public string MaKH { get; set; }

        public virtual ICollection<TienNghi> TienNghis { get; set; }

        public virtual TinhTP TinhTP { get; set; }

        public virtual QuanHuyen QuanHuyen { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}