using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NhaTro.Models
{
    [Table("QuanHuyen")]
    public class QuanHuyen
    {
        [Key]
        [StringLength(8)]
        public string MaQH { get; set; }
        [StringLength(50)]
        public string TenQH { get; set; }

        public string MaTTP { get; set; }

        public virtual TinhTP TinhTP { get; set; }
        public virtual ICollection<Phong> Phongs { get; set; }
        public virtual ICollection<Nha> Nhas { get; set; }
        public virtual ICollection<BaiDang> BaiDangs { get; set; }
    }
}