using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NhaTro.Models
{
    public class TinhTP
    {
        [Key]
        [StringLength(8)]
        public string MaTTP { get; set; }

        [StringLength(50)]
        public string TenTTP { get; set; }

        public virtual ICollection<QuanHuyen> QuanHuyens { get; set; }
    }
}