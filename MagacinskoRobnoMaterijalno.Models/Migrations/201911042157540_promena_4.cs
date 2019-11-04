namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promena_4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DocumentItems", "Document_ID", c => c.Long());
            CreateIndex("dbo.DocumentItems", "Document_ID");
            AddForeignKey("dbo.DocumentItems", "Document_ID", "dbo.Documents", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DocumentItems", "Document_ID", "dbo.Documents");
            DropIndex("dbo.DocumentItems", new[] { "Document_ID" });
            DropColumn("dbo.DocumentItems", "Document_ID");
        }
    }
}
