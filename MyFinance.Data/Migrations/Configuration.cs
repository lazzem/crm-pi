namespace MyFinance.Data.Migrations
{
    using Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyFinance.Data.MyFinanceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MyFinance.Data.MyFinanceContext";
        }

        protected override void Seed(MyFinance.Data.MyFinanceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Categories.AddOrUpdate(c=>c.Name,
                new Category(){ Name="légume"},
                new Category(){ Name="fruit"},
                new Category(){ Name = "meuble" }
                );
        }
    }
}
