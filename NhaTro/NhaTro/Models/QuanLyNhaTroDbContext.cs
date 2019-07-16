using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NhaTro.Models
{
    public class QuanLyNhaTroDbContext: DbContext 
    {
        public QuanLyNhaTroDbContext():base("name=QuanLyNhaTro")
        {

        }
        public virtual DbSet<TinhTP> TinhTPs { get; set; }
        public virtual DbSet<QuanHuyen> QuanHuyens { get; set; }
    }
}