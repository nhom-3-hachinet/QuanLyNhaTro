namespace NhaTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sua_database : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Nhas", newName: "Nha");
            RenameTable(name: "dbo.QuanHuyens", newName: "QuanHuyen");
            RenameTable(name: "dbo.Phongs", newName: "Phong");
            RenameTable(name: "dbo.TienNghis", newName: "TienNghi");
            RenameTable(name: "dbo.TinhTPs", newName: "TinhTP");
            CreateTable(
                "dbo.BaiDang",
                c => new
                    {
                        MaTin = c.String(nullable: false, maxLength: 8),
                        TieuDe = c.String(maxLength: 200),
                        Gia = c.String(maxLength: 50),
                        AnhBia = c.String(maxLength: 30),
                        DiaChi = c.String(maxLength: 100),
                        MaQH = c.String(maxLength: 8),
                        MaTTP = c.String(maxLength: 8),
                        SDT = c.String(maxLength: 12),
                    })
                .PrimaryKey(t => t.MaTin)
                .ForeignKey("dbo.QuanHuyen", t => t.MaQH)
                .ForeignKey("dbo.TinhTP", t => t.MaTTP)
                .Index(t => t.MaQH)
                .Index(t => t.MaTTP);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BaiDang", "MaTTP", "dbo.TinhTP");
            DropForeignKey("dbo.BaiDang", "MaQH", "dbo.QuanHuyen");
            DropIndex("dbo.BaiDang", new[] { "MaTTP" });
            DropIndex("dbo.BaiDang", new[] { "MaQH" });
            DropTable("dbo.BaiDang");
            RenameTable(name: "dbo.TinhTP", newName: "TinhTPs");
            RenameTable(name: "dbo.TienNghi", newName: "TienNghis");
            RenameTable(name: "dbo.Phong", newName: "Phongs");
            RenameTable(name: "dbo.QuanHuyen", newName: "QuanHuyens");
            RenameTable(name: "dbo.Nha", newName: "Nhas");
        }
    }
}
