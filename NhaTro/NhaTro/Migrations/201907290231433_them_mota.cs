namespace NhaTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class them_mota : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BaiDang", "MoTa", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BaiDang", "MoTa");
        }
    }
}
