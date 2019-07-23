namespace NhaTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class them_taikhoan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KhachHang", "TaiKhoan", c => c.String(maxLength: 30));
            AddColumn("dbo.KhachHang", "MatKhau", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            DropColumn("dbo.KhachHang", "MatKhau");
            DropColumn("dbo.KhachHang", "TaiKhoan");
        }
    }
}
