namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promena_3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        WarehouseTypeID = c.Int(nullable: false),
                        WarehouseNo = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Documents", "Warehouse_ID", c => c.Long());
            AlterColumn("dbo.Documents", "DocumentType", c => c.Int(nullable: false));
            CreateIndex("dbo.Documents", "Warehouse_ID");
            AddForeignKey("dbo.Documents", "Warehouse_ID", "dbo.Warehouses", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Documents", "Warehouse_ID", "dbo.Warehouses");
            DropIndex("dbo.Documents", new[] { "Warehouse_ID" });
            AlterColumn("dbo.Documents", "DocumentType", c => c.String());
            DropColumn("dbo.Documents", "Warehouse_ID");
            DropTable("dbo.Warehouses");
        }
    }
}
