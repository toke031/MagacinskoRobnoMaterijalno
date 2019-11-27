namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DocumentItems", "OrderDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DocumentItems", "OrderDate");
        }
    }
}
