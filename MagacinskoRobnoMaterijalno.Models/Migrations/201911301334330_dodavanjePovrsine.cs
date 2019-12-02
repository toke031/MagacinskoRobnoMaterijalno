namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodavanjePovrsine : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DocumentItems", "Surface", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DocumentItems", "Surface");
        }
    }
}
