namespace MyFinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FluentApiMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categories", newName: "MyCategories");
            RenameTable(name: "dbo.ProviderProducts", newName: "Providings");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            RenameColumn(table: "dbo.Providings", name: "Provider_Id", newName: "Provider");
            RenameColumn(table: "dbo.Providings", name: "Product_ProductId", newName: "Product");
            RenameIndex(table: "dbo.Providings", name: "IX_Product_ProductId", newName: "IX_Product");
            RenameIndex(table: "dbo.Providings", name: "IX_Provider_Id", newName: "IX_Provider");
            DropPrimaryKey("dbo.Providings");
            AddColumn("dbo.Products", "IsBiological", c => c.Int());
            AlterColumn("dbo.MyCategories", "Name", c => c.String(nullable: false, maxLength: 25));
            AddPrimaryKey("dbo.Providings", new[] { "Product", "Provider" });
            AddForeignKey("dbo.Products", "CategoryId", "dbo.MyCategories", "CategoryId", cascadeDelete: true);
            DropColumn("dbo.Products", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Products", "CategoryId", "dbo.MyCategories");
            DropPrimaryKey("dbo.Providings");
            AlterColumn("dbo.MyCategories", "Name", c => c.String());
            DropColumn("dbo.Products", "IsBiological");
            AddPrimaryKey("dbo.Providings", new[] { "Provider_Id", "Product_ProductId" });
            RenameIndex(table: "dbo.Providings", name: "IX_Provider", newName: "IX_Provider_Id");
            RenameIndex(table: "dbo.Providings", name: "IX_Product", newName: "IX_Product_ProductId");
            RenameColumn(table: "dbo.Providings", name: "Product", newName: "Product_ProductId");
            RenameColumn(table: "dbo.Providings", name: "Provider", newName: "Provider_Id");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "CategoryId");
            RenameTable(name: "dbo.Providings", newName: "ProviderProducts");
            RenameTable(name: "dbo.MyCategories", newName: "Categories");
        }
    }
}
