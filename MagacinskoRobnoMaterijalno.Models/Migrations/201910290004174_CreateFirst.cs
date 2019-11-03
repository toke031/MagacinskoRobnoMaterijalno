namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateFirst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        ArticleNo = c.String(),
                        Name = c.String(),
                        Quantity = c.Int(nullable: false),
                        Width = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        PIB = c.String(),
                        MB = c.String(),
                        Address = c.String(),
                        BankAccount = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        PhoneFax = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
            DropTable("dbo.Articles");
        }
    }
}
