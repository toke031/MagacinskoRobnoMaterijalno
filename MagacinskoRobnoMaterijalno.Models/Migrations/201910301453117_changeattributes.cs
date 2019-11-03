namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeattributes : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Articles", "Quantity");
            DropColumn("dbo.Articles", "Width");
            DropColumn("dbo.Articles", "Height");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Articles", "Height", c => c.Int(nullable: false));
            AddColumn("dbo.Articles", "Width", c => c.Int(nullable: false));
            AddColumn("dbo.Articles", "Quantity", c => c.Int(nullable: false));
        }
    }
}
