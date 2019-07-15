namespace NhaTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuanHuyens",
                c => new
                    {
                        MaQH = c.String(nullable: false, maxLength: 8),
                        TenQP = c.String(maxLength: 50),
                        MaTTP = c.String(maxLength: 8),
                    })
                .PrimaryKey(t => t.MaQH)
                .ForeignKey("dbo.TinhTPs", t => t.MaTTP)
                .Index(t => t.MaTTP);
            
            CreateTable(
                "dbo.TinhTPs",
                c => new
                    {
                        MaTTP = c.String(nullable: false, maxLength: 8),
                        TenTTP = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaTTP);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuanHuyens", "MaTTP", "dbo.TinhTPs");
            DropIndex("dbo.QuanHuyens", new[] { "MaTTP" });
            DropTable("dbo.TinhTPs");
            DropTable("dbo.QuanHuyens");
        }
    }
}
