namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentDocumentItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DocumentItems",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        ItemID = c.Long(nullable: false),
                        DocumentID = c.Int(nullable: false),
                        ItemPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ItemName = c.String(),
                        WareHouseID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        QuantityItemPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        DocumentNo = c.String(),
                        DocumentType = c.String(),
                        ClientID = c.Long(nullable: false),
                        DocumentDateTime = c.DateTime(nullable: false),
                        PaymentEndDate = c.DateTime(nullable: false),
                        PaymentDate = c.DateTime(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Documents");
            DropTable("dbo.DocumentItems");
        }
    }
}
