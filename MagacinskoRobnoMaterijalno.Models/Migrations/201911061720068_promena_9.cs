namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promena_9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "QuantityItemPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articles", "QuantityItemPrice");
        }
    }
}
