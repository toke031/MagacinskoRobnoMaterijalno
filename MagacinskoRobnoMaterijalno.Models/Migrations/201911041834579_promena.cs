namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promena : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Documents", "Client_ID", c => c.Long());
            CreateIndex("dbo.Documents", "Client_ID");
            AddForeignKey("dbo.Documents", "Client_ID", "dbo.Clients", "ID");
            DropColumn("dbo.Documents", "ClientID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Documents", "ClientID", c => c.Long(nullable: false));
            DropForeignKey("dbo.Documents", "Client_ID", "dbo.Clients");
            DropIndex("dbo.Documents", new[] { "Client_ID" });
            DropColumn("dbo.Documents", "Client_ID");
        }
    }
}
