namespace NhaTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 8),
                        TenKH = c.String(nullable: false, maxLength: 50),
                        DiaChi = c.String(maxLength: 300),
                        Sdt = c.String(maxLength: 15),
                        Email = c.String(maxLength: 50),
                        MaQT = c.String(maxLength: 8),
                    })
                .PrimaryKey(t => t.MaKH)
                .ForeignKey("dbo.QuocTich", t => t.MaQT)
                .Index(t => t.MaQT);
            
            CreateTable(
                "dbo.Nhas",
                c => new
                    {
                        MaNha = c.String(nullable: false, maxLength: 8),
                        SoPhong = c.String(maxLength: 10),
                        DiaChi = c.String(maxLength: 300),
                        Gia = c.Int(nullable: false),
                        MaTTP = c.String(maxLength: 8),
                        MaQH = c.String(maxLength: 8),
                        MaKH = c.String(maxLength: 8),
                    })
                .PrimaryKey(t => t.MaNha)
                .ForeignKey("dbo.KhachHang", t => t.MaKH)
                .ForeignKey("dbo.QuanHuyens", t => t.MaQH)
                .ForeignKey("dbo.TinhTPs", t => t.MaTTP)
                .Index(t => t.MaTTP)
                .Index(t => t.MaQH)
                .Index(t => t.MaKH);
            
            CreateTable(
                "dbo.Phongs",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 8),
                        SoPhong = c.Int(nullable: false),
                        DienTich = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiaChi = c.String(maxLength: 300),
                        MaTTP = c.String(maxLength: 8),
                        MaQH = c.String(maxLength: 8),
                        MaKH = c.String(maxLength: 8),
                    })
                .PrimaryKey(t => t.MaPhong)
                .ForeignKey("dbo.KhachHang", t => t.MaKH)
                .ForeignKey("dbo.QuanHuyens", t => t.MaQH)
                .ForeignKey("dbo.TinhTPs", t => t.MaTTP)
                .Index(t => t.MaTTP)
                .Index(t => t.MaQH)
                .Index(t => t.MaKH);
            
            CreateTable(
                "dbo.TienNghis",
                c => new
                    {
                        MaTN = c.String(nullable: false, maxLength: 8),
                        TenTN = c.String(maxLength: 50),
                        SoLuong = c.Int(nullable: false),
                        MaPhong = c.String(maxLength: 8),
                        MaNha = c.String(maxLength: 8),
                    })
                .PrimaryKey(t => t.MaTN)
                .ForeignKey("dbo.Nhas", t => t.MaNha)
                .ForeignKey("dbo.Phongs", t => t.MaPhong)
                .Index(t => t.MaPhong)
                .Index(t => t.MaNha);
            
            CreateTable(
                "dbo.QuocTich",
                c => new
                    {
                        MaQT = c.String(nullable: false, maxLength: 8),
                        TenNuoc = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaQT);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KhachHang", "MaQT", "dbo.QuocTich");
            DropForeignKey("dbo.Phongs", "MaTTP", "dbo.TinhTPs");
            DropForeignKey("dbo.Nhas", "MaTTP", "dbo.TinhTPs");
            DropForeignKey("dbo.TienNghis", "MaPhong", "dbo.Phongs");
            DropForeignKey("dbo.TienNghis", "MaNha", "dbo.Nhas");
            DropForeignKey("dbo.Phongs", "MaQH", "dbo.QuanHuyens");
            DropForeignKey("dbo.Phongs", "MaKH", "dbo.KhachHang");
            DropForeignKey("dbo.Nhas", "MaQH", "dbo.QuanHuyens");
            DropForeignKey("dbo.Nhas", "MaKH", "dbo.KhachHang");
            DropIndex("dbo.TienNghis", new[] { "MaNha" });
            DropIndex("dbo.TienNghis", new[] { "MaPhong" });
            DropIndex("dbo.Phongs", new[] { "MaKH" });
            DropIndex("dbo.Phongs", new[] { "MaQH" });
            DropIndex("dbo.Phongs", new[] { "MaTTP" });
            DropIndex("dbo.Nhas", new[] { "MaKH" });
            DropIndex("dbo.Nhas", new[] { "MaQH" });
            DropIndex("dbo.Nhas", new[] { "MaTTP" });
            DropIndex("dbo.KhachHang", new[] { "MaQT" });
            DropTable("dbo.QuocTich");
            DropTable("dbo.TienNghis");
            DropTable("dbo.Phongs");
            DropTable("dbo.Nhas");
            DropTable("dbo.KhachHang");
        }
    }
}
