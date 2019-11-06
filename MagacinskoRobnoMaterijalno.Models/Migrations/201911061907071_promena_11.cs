namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promena_11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DocumentItems", "Quantity", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DocumentItems", "Quantity", c => c.Int(nullable: false));
        }
    }
}
