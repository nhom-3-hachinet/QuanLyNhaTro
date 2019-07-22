using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NhaTro.Models
{
    public class TienNghi
    {
        [Key]
        [StringLength(8)]
        public string MaTN { get; set; }

        [StringLength(50)]
        public string TenTN { get; set; }

        public int SoLuong { get; set; }

        public string MaPhong { get; set; }

        public string MaNha { get; set; }

        public virtual Phong Phong { get; set; }

        public virtual Nha Nha { get; set; }

    }
}