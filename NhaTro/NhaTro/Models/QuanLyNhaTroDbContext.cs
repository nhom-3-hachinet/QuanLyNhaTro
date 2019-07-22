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
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Nha> Nhas { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<QuocTich> QuocTichs { get; set; }
        public virtual DbSet<TienNghi> TienNghis { get; set; }

    }
}