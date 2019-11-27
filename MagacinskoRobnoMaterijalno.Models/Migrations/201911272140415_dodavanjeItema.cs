namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodavanjeItema : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.DocumentItems", "ItemID");
            AddForeignKey("dbo.DocumentItems", "ItemID", "dbo.Articles", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DocumentItems", "ItemID", "dbo.Articles");
            DropIndex("dbo.DocumentItems", new[] { "ItemID" });
        }
    }
}
