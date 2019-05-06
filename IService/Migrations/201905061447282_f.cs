namespace IService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Dishes", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dishes", "Image", c => c.Binary());
        }
    }
}
