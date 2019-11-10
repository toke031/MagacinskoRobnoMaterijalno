namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promena14 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Articles", "Warehouse_ID", "dbo.Warehouses");
            DropIndex("dbo.Articles", new[] { "Warehouse_ID" });
            DropColumn("dbo.Articles", "Warehouse_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Articles", "Warehouse_ID", c => c.Long());
            CreateIndex("dbo.Articles", "Warehouse_ID");
            AddForeignKey("dbo.Articles", "Warehouse_ID", "dbo.Warehouses", "ID");
        }
    }
}
