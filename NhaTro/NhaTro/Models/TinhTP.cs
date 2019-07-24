using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NhaTro.Models
{
    [Table("TinhTP")]
    public class TinhTP
    {
        [Key]
        [StringLength(8)]
        public string MaTTP { get; set; }

        [StringLength(50)]
        [DisplayName("Tên Tỉnh, Thành phố")]
        public string TenTTP { get; set; }

        public virtual ICollection<QuanHuyen> QuanHuyens { get; set; }

        public virtual ICollection<Phong> Phongs { get; set; }
        public virtual ICollection<BaiDang> BaiDangs { get; set; }
        public virtual ICollection<Nha> Nhas { get; set; }
    }
}