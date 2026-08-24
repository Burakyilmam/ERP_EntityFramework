using System.Data.Entity.ModelConfiguration;

namespace ERP_EntityFramework.DataAccess.Configurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Name).HasMaxLength(150);

            Property(x => x.Surname).HasMaxLength(150);

            Property(x => x.CompanyName).HasMaxLength(250);

            Property(x => x.CustomerCode).IsRequired().HasMaxLength(50);

            Property(x => x.TaxNumber).HasMaxLength(50);

            Property(x => x.Notes).HasMaxLength(4096);

            HasIndex(x => x.CustomerCode).IsUnique();

            HasMany(x => x.Phones)
                .WithRequired(x => x.Customer)
                .HasForeignKey(x => x.CustomerId)
                .WillCascadeOnDelete(true);

            HasMany(x => x.Emails)
                .WithRequired(x => x.Customer)
                .HasForeignKey(x => x.CustomerId)
                .WillCascadeOnDelete(true);

            HasMany(x => x.Addresses)
                .WithRequired(x => x.Customer)
                .HasForeignKey(x => x.CustomerId)
                .WillCascadeOnDelete(true);
        }
    }
}