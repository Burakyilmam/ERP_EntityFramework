using System.Data.Entity.ModelConfiguration;

namespace ERP_EntityFramework.DataAccess.Configurations
{
    public class AddressConfiguration : EntityTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Country).IsRequired().HasMaxLength(100);

            Property(x => x.City).IsRequired().HasMaxLength(100);

            Property(x => x.District).HasMaxLength(100);

            Property(x => x.Neighborhood).HasMaxLength(150);

            Property(x => x.Street).HasMaxLength(250);

            Property(x => x.PostalCode).HasMaxLength(20);

            HasRequired(x => x.Customer)
                .WithMany(x => x.Addresses)
                .HasForeignKey(x => x.CustomerId)
                .WillCascadeOnDelete(true);
        }
    }
}