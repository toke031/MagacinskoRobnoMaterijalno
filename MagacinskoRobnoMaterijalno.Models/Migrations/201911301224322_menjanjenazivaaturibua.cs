namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class menjanjenazivaaturibua : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "ItemPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Articles", "QuantityItemPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Articles", "QuantityItemPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Articles", "ItemPrice");
        }
    }
}
