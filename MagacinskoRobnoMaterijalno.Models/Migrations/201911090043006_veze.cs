namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class veze : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DocumentItems", "ItemID", "dbo.Articles");
            DropIndex("dbo.DocumentItems", new[] { "ItemID" });
            RenameColumn(table: "dbo.Articles", name: "ItemID", newName: "DocumentItem_ID");
            CreateIndex("dbo.Articles", "DocumentItem_ID");
            AddForeignKey("dbo.Articles", "DocumentItem_ID", "dbo.DocumentItems", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "DocumentItem_ID", "dbo.DocumentItems");
            DropIndex("dbo.Articles", new[] { "DocumentItem_ID" });
            RenameColumn(table: "dbo.Articles", name: "DocumentItem_ID", newName: "ItemID");
            CreateIndex("dbo.DocumentItems", "ItemID");
            AddForeignKey("dbo.DocumentItems", "ItemID", "dbo.Articles", "ID", cascadeDelete: true);
        }
    }
}
