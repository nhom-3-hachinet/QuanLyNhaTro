namespace NhaTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xoa_thuoctinh : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.KhachHang", "TaiKhoan", c => c.String());
            DropColumn("dbo.KhachHang", "MaQT");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KhachHang", "MaQT", c => c.String());
            AlterColumn("dbo.KhachHang", "TaiKhoan", c => c.String(maxLength: 30));
        }
    }
}
