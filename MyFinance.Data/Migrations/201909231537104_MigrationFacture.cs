namespace MyFinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationFacture : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Factures",
                c => new
                    {
                        DateAchat = c.String(nullable: false, maxLength: 128),
                        ClientFK = c.Int(nullable: false),
                        ProductFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DateAchat)
                .ForeignKey("dbo.Clients", t => t.ClientFK, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductFK, cascadeDelete: true)
                .Index(t => t.ClientFK)
                .Index(t => t.ProductFK);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        CIN = c.Int(nullable: false, identity: true),
                        DateNaissance = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Mail = c.String(),
                        Nom = c.String(),
                        Prenom = c.String(),
                    })
                .PrimaryKey(t => t.CIN);
            
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Providers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Providers", "Password", c => c.String(nullable: false));
            DropColumn("dbo.Providers", "ConfirmPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Providers", "ConfirmPassword", c => c.String());
            DropForeignKey("dbo.Factures", "ProductFK", "dbo.Products");
            DropForeignKey("dbo.Factures", "ClientFK", "dbo.Clients");
            DropIndex("dbo.Factures", new[] { "ProductFK" });
            DropIndex("dbo.Factures", new[] { "ClientFK" });
            AlterColumn("dbo.Providers", "Password", c => c.String());
            AlterColumn("dbo.Providers", "Email", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
            DropTable("dbo.Clients");
            DropTable("dbo.Factures");
        }
    }
}
