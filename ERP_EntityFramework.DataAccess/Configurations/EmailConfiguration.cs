using System.Data.Entity.ModelConfiguration;

namespace ERP_EntityFramework.DataAccess.Configurations
{
    public class EmailConfiguration : EntityTypeConfiguration<Email>
    {
        public EmailConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.EmailAddress).IsRequired().HasMaxLength(150);

            HasRequired(x => x.Customer)
                .WithMany(x => x.Emails)
                .HasForeignKey(x => x.CustomerId)
                .WillCascadeOnDelete(true);
        }
    }
}