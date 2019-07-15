using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NhaTro.Models
{
    public class QuanHuyen
    {
        [Key]
        [StringLength(8)]
        public string MaQH { get; set; }
        [StringLength(50)]
        public string TenQP { get; set; }

        public string MaTTP { get; set; }

        public virtual TinhTP TinhTP { get; set; }
    }
}