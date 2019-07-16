using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NhaTro.Models
{
    public class Nha
    {
        [Key]
        public string MaNha { get; set; }
        [StringLength(10)]
        public string SoPhong { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        public int  Gia { get; set; }
        public string MaTTP { get; set; }
        public string MaQH { get; set; }
        public string MaKH { get; set; }
    }
}