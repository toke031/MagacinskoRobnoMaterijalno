namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promena_8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DocumentItems", "ArticleNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DocumentItems", "ArticleNo");
        }
    }
}
