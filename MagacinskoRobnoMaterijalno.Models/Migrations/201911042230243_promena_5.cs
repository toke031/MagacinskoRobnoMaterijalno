namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promena_5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.DocumentItems", "DocumentID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DocumentItems", "DocumentID", c => c.Int(nullable: false));
        }
    }
}
