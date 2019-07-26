using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using NhaTro.Models;

namespace NhaTro
{
    public class NewPostViewModel
    {
        public string MaTin { get; set; }
        [StringLength(200)]
        public string TieuDe { get; set; }
        [StringLength(50)]
        public string Gia { get; set; }
        [StringLength(30)]
        public string AnhBia { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        public List<QuanHuyen> MaQH { get; set; }
        public List<TinhTP> MaTTP { get; set; }
        [StringLength(12)]
        public string SDT { get; set; }
        public int Moi { get; set; }
    }
}