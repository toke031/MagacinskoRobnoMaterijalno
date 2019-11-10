namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pocetak : DbMigration
    {
        public override void Up()
        {
            //DropIndex("dbo.Articles", new[] { "Warehouse_ID1" });
            //DropColumn("dbo.Articles", "Warehouse_ID");
            //RenameColumn(table: "dbo.Articles", name: "Warehouse_ID1", newName: "Warehouse_ID");
            //AlterColumn("dbo.Articles", "Warehouse_ID", c => c.Long());
            //CreateIndex("dbo.Articles", "Warehouse_ID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Articles", new[] { "Warehouse_ID" });
            AlterColumn("dbo.Articles", "Warehouse_ID", c => c.Long(nullable: false));
            RenameColumn(table: "dbo.Articles", name: "Warehouse_ID", newName: "Warehouse_ID1");
            AddColumn("dbo.Articles", "Warehouse_ID", c => c.Long(nullable: false));
            CreateIndex("dbo.Articles", "Warehouse_ID1");
        }
    }
}
