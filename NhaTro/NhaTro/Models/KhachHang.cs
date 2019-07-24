using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Tên Khách Hàng")]
        public string TenKH { get; set; }

        [DisplayName("Địa Chỉ")]
        [StringLength(300)]
        public string DiaChi { get; set; }

        [StringLength(15)]
        [DisplayName("Số Điện Thoại")]
        public string Sdt { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [DisplayName("Tài Khoản")]
        public string TaiKhoan { get; set; }
        [StringLength(30)]
        [DisplayName("Mật Khẩu")]
        public string MatKhau { get; set; }

        public virtual ICollection<Phong> Phongs { get; set; }
        public virtual ICollection<Nha> Nhas { get; set; }
    }
}