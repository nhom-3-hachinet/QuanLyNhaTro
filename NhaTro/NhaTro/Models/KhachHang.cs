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
        [StringLength(8)]
        public string MaKH { get; set; }

        [StringLength(50)]
        [Required]
        public string TenKH { get; set; }

        [StringLength(300)]
        public string DiaChi { get; set; }

        [StringLength(15)]
        public string Sdt { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public string MaQT { get; set; }
        [StringLength(30)]
        public string TaiKhoan { get; set; }
        [StringLength(30)]
        public string MatKhau { get; set; }

        public virtual ICollection<Phong> Phongs { get; set; }
        public virtual ICollection<Nha> Nhas { get; set; }
    }
}