namespace NhaTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sua_tenqh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.QuanHuyen", "TenQH", c => c.String(maxLength: 50));
            DropColumn("dbo.QuanHuyen", "TenQP");
        }
        
        public override void Down()
        {
            AddColumn("dbo.QuanHuyen", "TenQP", c => c.String(maxLength: 50));
            DropColumn("dbo.QuanHuyen", "TenQH");
        }
    }
}
