namespace NhaTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xoa_qtich : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.KhachHang", "MaQT", "dbo.QuocTich");
            DropIndex("dbo.KhachHang", new[] { "MaQT" });
            AlterColumn("dbo.KhachHang", "MaQT", c => c.String());
            DropTable("dbo.QuocTich");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.QuocTich",
                c => new
                    {
                        MaQT = c.String(nullable: false, maxLength: 8),
                        TenNuoc = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaQT);
            
            AlterColumn("dbo.KhachHang", "MaQT", c => c.String(maxLength: 8));
            CreateIndex("dbo.KhachHang", "MaQT");
            AddForeignKey("dbo.KhachHang", "MaQT", "dbo.QuocTich", "MaQT");
        }
    }
}
