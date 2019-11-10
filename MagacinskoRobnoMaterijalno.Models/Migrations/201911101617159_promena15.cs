namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promena15 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Documents", "Warehouse_ID", "dbo.Warehouses");
            DropIndex("dbo.Documents", new[] { "Warehouse_ID" });
            AddColumn("dbo.Documents", "Warehouse_ID", c => c.Long());
            AlterColumn("dbo.Documents", "Warehouse_ID", c => c.Long(nullable: false));
            CreateIndex("dbo.Documents", "Warehouse_ID");
            AddForeignKey("dbo.Documents", "Warehouse_ID", "dbo.Warehouses", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Documents", "Warehouse_ID", "dbo.Warehouses");
            DropIndex("dbo.Documents", new[] { "Warehouse_ID" });
            AlterColumn("dbo.Documents", "Warehouse_ID", c => c.Long());
            DropColumn("dbo.Documents", "Warehouse_ID");
            CreateIndex("dbo.Documents", "Warehouse_ID");
            AddForeignKey("dbo.Documents", "Warehouse_ID", "dbo.Warehouses", "ID");
        }
    }
}
