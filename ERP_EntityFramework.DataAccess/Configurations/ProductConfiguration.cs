using ERP_EntityFramework_Entities.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ERP_EntityFramework.DataAccess.Configurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Code).IsRequired().HasMaxLength(50);

            Property(x => x.Name).IsRequired().HasMaxLength(200);

            Property(x => x.Barcode).HasMaxLength(100);

            Property(x => x.PurchasePrice).HasPrecision(18, 2);

            Property(x => x.SalePrice).HasPrecision(18, 2);

            Property(x => x.Description).HasMaxLength(4000);

            HasIndex(x => x.Code).IsUnique();

            HasIndex(x => x.Barcode).IsUnique();

            HasRequired(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId)
                .WillCascadeOnDelete(false);

            HasRequired(x => x.Unit)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.UnitId)
                .WillCascadeOnDelete(false);
        }
    }
}