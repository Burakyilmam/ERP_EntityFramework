using ERP_EntityFramework_Entities;
using System.Data.Entity.ModelConfiguration;

namespace ERP_EntityFramework.DataAccess.Configurations
{
    public class TabConfiguration : EntityTypeConfiguration<Tab>
    {
        public TabConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.TabName)
                .IsRequired()
                .HasMaxLength(150);

            Property(x => x.FormNo)
                .IsRequired()
                .HasMaxLength(50);

            HasRequired(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserID)
                .WillCascadeOnDelete(true);
        }
    }
}