using System.Data.Entity.ModelConfiguration;

namespace ERP_EntityFramework.DataAccess.Configurations
{
    public class PhoneConfiguration : EntityTypeConfiguration<Phone>
    {
        public PhoneConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.PhoneNumber).IsRequired().HasMaxLength(30);

            Property(x => x.CountryCode).HasMaxLength(10);

            HasRequired(x => x.Customer)
                .WithMany(x => x.Phones)
                .HasForeignKey(x => x.CustomerId)
                .WillCascadeOnDelete(true);
        }
    }
}