namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class groupByPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Documents", "ItemsGroupByPrice", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Documents", "ItemsGroupByPrice");
        }
    }
}
