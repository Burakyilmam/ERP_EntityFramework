using System.Data.Entity.ModelConfiguration;

namespace ERP_EntityFramework.DataAccess.Configurations
{
    public class CalendarConfiguration : EntityTypeConfiguration<Calendar>
    {
        public CalendarConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Title).IsRequired().HasMaxLength(200);

            Property(x => x.Note).HasMaxLength(4000);

            HasRequired(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .WillCascadeOnDelete(true);
        }
    }
}