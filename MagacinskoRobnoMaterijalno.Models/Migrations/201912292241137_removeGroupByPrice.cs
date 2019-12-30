namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeGroupByPrice : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Documents", "ItemsGroupByPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Documents", "ItemsGroupByPrice", c => c.String());
        }
    }
}
