namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class spoljni_broj : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Documents", "LinkDocumentNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Documents", "LinkDocumentNo");
        }
    }
}
