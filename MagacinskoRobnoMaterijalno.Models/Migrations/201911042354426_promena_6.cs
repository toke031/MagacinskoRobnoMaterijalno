namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promena_6 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.DocumentItems", "ItemID");
            AddForeignKey("dbo.DocumentItems", "ItemID", "dbo.Articles", "ID", cascadeDelete: true);
            DropColumn("dbo.DocumentItems", "ItemName");
            DropColumn("dbo.DocumentItems", "WareHouseID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DocumentItems", "WareHouseID", c => c.Int(nullable: false));
            AddColumn("dbo.DocumentItems", "ItemName", c => c.String());
            DropForeignKey("dbo.DocumentItems", "ItemID", "dbo.Articles");
            DropIndex("dbo.DocumentItems", new[] { "ItemID" });
        }
    }
}
