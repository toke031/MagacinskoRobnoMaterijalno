namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promena18 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Documents", "Warehouse_ID1", "dbo.Warehouses");
            DropIndex("dbo.Documents", new[] { "Warehouse_ID1" });
            RenameColumn(table: "dbo.Documents", name: "Warehouse_ID1", newName: "WarehouseID");
            AlterColumn("dbo.Documents", "WarehouseID", c => c.Long(nullable: false));
            CreateIndex("dbo.Documents", "WarehouseID");
            AddForeignKey("dbo.Documents", "WarehouseID", "dbo.Warehouses", "ID", cascadeDelete: true);
            DropColumn("dbo.Documents", "Warehouse_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Documents", "Warehouse_ID", c => c.Long(nullable: false));
            DropForeignKey("dbo.Documents", "WarehouseID", "dbo.Warehouses");
            DropIndex("dbo.Documents", new[] { "WarehouseID" });
            AlterColumn("dbo.Documents", "WarehouseID", c => c.Long());
            RenameColumn(table: "dbo.Documents", name: "WarehouseID", newName: "Warehouse_ID1");
            CreateIndex("dbo.Documents", "Warehouse_ID1");
            AddForeignKey("dbo.Documents", "Warehouse_ID1", "dbo.Warehouses", "ID");
        }
    }
}
