namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promena_10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Documents", "TotalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Documents", "TotalPrice", c => c.Int(nullable: false));
        }
    }
}
