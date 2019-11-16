namespace MagacinskoRobnoMaterijalno.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        ArticleNo = c.String(),
                        Name = c.String(),
                        QuantityItemPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ArticleTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        PIB = c.String(),
                        MB = c.String(),
                        Address = c.String(),
                        BankAccount = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        PhoneFax = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        DocumentNo = c.String(),
                        DocumentType = c.Int(nullable: false),
                        DocumentDateTime = c.DateTime(nullable: false),
                        PaymentEndDate = c.DateTime(nullable: false),
                        PaymentDate = c.DateTime(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientID = c.Long(nullable: false),
                        WarehouseID = c.Long(nullable: false),
                        StatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clients", t => t.ClientID, cascadeDelete: true)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseID, cascadeDelete: true)
                .Index(t => t.ClientID)
                .Index(t => t.WarehouseID);
            
            CreateTable(
                "dbo.DocumentItems",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        DocumentID = c.Long(nullable: false),
                        ItemPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ArticleNo = c.String(),
                        ItemID = c.Long(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuantityItemPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Documents", t => t.DocumentID, cascadeDelete: true)
                .Index(t => t.DocumentID);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Documents", "WarehouseID", "dbo.Warehouses");
            DropForeignKey("dbo.DocumentItems", "DocumentID", "dbo.Documents");
            DropForeignKey("dbo.Documents", "ClientID", "dbo.Clients");
            DropIndex("dbo.DocumentItems", new[] { "DocumentID" });
            DropIndex("dbo.Documents", new[] { "WarehouseID" });
            DropIndex("dbo.Documents", new[] { "ClientID" });
            DropTable("dbo.Warehouses");
            DropTable("dbo.DocumentItems");
            DropTable("dbo.Documents");
            DropTable("dbo.Clients");
            DropTable("dbo.Articles");
        }
    }
}
