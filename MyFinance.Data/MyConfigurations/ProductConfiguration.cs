using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.MyConfigurations
{
    public class ProductConfiguration:EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            //ManyToMany Configuration
            HasMany(p => p.ProviderList).WithMany(p => p.ProductList).
                Map(r => { r.ToTable("Providings");
                    r.MapLeftKey("Product");
                    r.MapRightKey("Provider");
                });
            //ManyToOne/Zero
            HasOptional(c => c.Categorie).WithMany(c => c.ProdList).HasForeignKey(p => p.CategoryId).WillCascadeOnDelete(true);
            //Heritage
            Map<Biological>(b => b.Requires("IsBiological").HasValue(1));
            Map<Chemical>(b => b.Requires("IsBiological").HasValue(0));
        }
    }
}
