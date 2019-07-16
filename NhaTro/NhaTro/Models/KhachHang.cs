using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NhaTro.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public string MaKH { get; set; }
        [StringLength(50)]
        public string TenKH { get; set; }
        [StringLength(300)]
        public string DiaChi { get; set; }
        [StringLength(15)]
        public string Sdt { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
    }
}