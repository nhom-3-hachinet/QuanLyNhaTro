using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NhaTro.Models
{
    [Table("BaiDang")]
    public class BaiDang
    {
        [Key]
        [StringLength(8)]
        public string MaTin { get; set; }
        [StringLength(200)]
        public string TieuDe { get; set; }
        public string MoTa { get; set; }

        [StringLength(50)]
        public string Gia { get; set; }
        [StringLength(30)]
        public string AnhBia { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        public string MaQH { get; set; }
        public string MaTTP { get; set; }
        [StringLength(12)]
        public string SDT { get; set; }
        public int Moi { get; set; }
        public virtual TinhTP TinhTP { get; set; }
        public virtual QuanHuyen QuanHuyen { get; set; }

    }
}