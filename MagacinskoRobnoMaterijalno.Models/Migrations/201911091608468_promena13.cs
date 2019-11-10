namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promena13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "ArticleTypeID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articles", "ArticleTypeID");
        }
    }
}
