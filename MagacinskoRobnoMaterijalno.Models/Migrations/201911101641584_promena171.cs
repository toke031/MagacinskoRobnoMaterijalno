namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promena171 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Documents", "Warehouse_ID", c => c.Long());
            DropForeignKey("dbo.Documents", "Warehouse_ID", "dbo.Warehouses");
            DropIndex("dbo.Documents", new[] { "Warehouse_ID" });
            AddColumn("dbo.Documents", "Warehouse_ID1", c => c.Long());
            AlterColumn("dbo.Documents", "Warehouse_ID", c => c.Long(nullable: false));
            CreateIndex("dbo.Documents", "Warehouse_ID1");
            AddForeignKey("dbo.Documents", "Warehouse_ID1", "dbo.Warehouses", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Documents", "Warehouse_ID1", "dbo.Warehouses");
            DropIndex("dbo.Documents", new[] { "Warehouse_ID1" });
            AlterColumn("dbo.Documents", "Warehouse_ID", c => c.Long());
            DropColumn("dbo.Documents", "Warehouse_ID1");
            CreateIndex("dbo.Documents", "Warehouse_ID");
            AddForeignKey("dbo.Documents", "Warehouse_ID", "dbo.Warehouses", "ID");
        }
    }
}
