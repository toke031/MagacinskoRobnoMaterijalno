namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promena : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Documents", "ClientID", c => c.Long());
            CreateIndex("dbo.Documents", "ClientID");
            AddForeignKey("dbo.Documents", "ClientID", "dbo.Clients", "ID");
            DropColumn("dbo.Documents", "ClientID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Documents", "ClientID", c => c.Long(nullable: false));
            DropForeignKey("dbo.Documents", "ClientID", "dbo.Clients");
            DropIndex("dbo.Documents", new[] { "ClientID" });
            DropColumn("dbo.Documents", "ClientID");
        }
    }
}
