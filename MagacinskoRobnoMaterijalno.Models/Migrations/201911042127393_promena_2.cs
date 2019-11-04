namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promena_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Documents", "StatusID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Documents", "StatusID");
        }
    }
}
