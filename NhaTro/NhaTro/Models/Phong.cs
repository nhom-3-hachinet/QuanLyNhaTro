using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NhaTro.Models
{
    public class Phong
    {
        public string MaPhong { get; set; }
        public int SoPhong { get; set; }

        public decimal DienTich { get; set; }
        public string DiaChi { get; set; }
        public string MaTTP { get; set; }
        public string MaQH { get; set; }
        public string MaKH { get; set; }
    }
}