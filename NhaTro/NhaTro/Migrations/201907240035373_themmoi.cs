namespace NhaTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class themmoi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BaiDang", "Moi", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BaiDang", "Moi");
        }
    }
}
