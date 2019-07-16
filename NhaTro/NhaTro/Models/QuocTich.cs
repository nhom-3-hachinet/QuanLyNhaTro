using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NhaTro.Models
{
    [Table("QuocTich")]
    public class QuocTich
    {
        [Key]
        public string MaQT { get; set; }
        [StringLength(50)]
        public string TenNuoc { get; set; }
        
    }
}