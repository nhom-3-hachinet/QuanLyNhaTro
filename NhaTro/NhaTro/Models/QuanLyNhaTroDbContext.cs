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
        public DbSet<BaiDang> BaiDangs { get; set; }
        public DbSet<TinhTP> TinhTPs { get; set; }
        public DbSet<QuanHuyen> QuanHuyens { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<Nha> Nhas { get; set; }
        public DbSet<Phong> Phongs { get; set; }
        public DbSet<TienNghi> TienNghis { get; set; }

    }
}