namespace IService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kertfrdf : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        LittleDescription = c.String(),
                        Recept = c.String(),
                        Image = c.Binary(),
                        TypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Types", t => t.TypeID, cascadeDelete: true)
                .Index(t => t.TypeID);
            
            CreateTable(
                "dbo.Intermediate",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DishID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Dishes", t => t.DishID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.DishID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserProducts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        TelegramID = c.String(),
                        Email = c.String(),
                        ISConfirmed = c.Boolean(nullable: false),
                        DateOfRegister = c.DateTime(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        DoesWantRecomendations = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EmailVerification",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        VerificationCode = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductNeeded = c.String(),
                        Recept = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dishes", "TypeID", "dbo.Types");
            DropForeignKey("dbo.Intermediate", "ProductID", "dbo.Products");
            DropForeignKey("dbo.UserProducts", "UserID", "dbo.Users");
            DropForeignKey("dbo.EmailVerification", "UserID", "dbo.Users");
            DropForeignKey("dbo.UserProducts", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Intermediate", "DishID", "dbo.Dishes");
            DropIndex("dbo.EmailVerification", new[] { "UserID" });
            DropIndex("dbo.UserProducts", new[] { "ProductID" });
            DropIndex("dbo.UserProducts", new[] { "UserID" });
            DropIndex("dbo.Intermediate", new[] { "ProductID" });
            DropIndex("dbo.Intermediate", new[] { "DishID" });
            DropIndex("dbo.Dishes", new[] { "TypeID" });
            DropTable("dbo.Promotions");
            DropTable("dbo.Types");
            DropTable("dbo.EmailVerification");
            DropTable("dbo.Users");
            DropTable("dbo.UserProducts");
            DropTable("dbo.Products");
            DropTable("dbo.Intermediate");
            DropTable("dbo.Dishes");
        }
    }
}
