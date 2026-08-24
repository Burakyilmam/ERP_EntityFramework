using ERP_EntityFramework_Entities;
using System.Data.Entity.ModelConfiguration;

namespace ERP_EntityFramework.DataAccess.Configurations
{
    public class SessionConfiguration : EntityTypeConfiguration<Session>
    {
        public SessionConfiguration()
        {
            HasKey(x => x.Id);

            HasOptional(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}