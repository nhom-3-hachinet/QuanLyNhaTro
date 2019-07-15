using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NhaTro.Models
{
    [Table("QuocTich")]
    public class QuocTich
    {
        public string MaQT { get; set; }
        public string TenNuoc { get; set; }
    }
}