using ERP_EntityFramework_Entities;
using System.Data.Entity.ModelConfiguration;

namespace ERP_EntityFramework.DataAccess.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Username).IsRequired().HasMaxLength(50);
            HasIndex(x => x.Username).IsUnique();

            Property(x => x.PasswordHash).IsRequired();

            HasMany(x => x.UserRoles).WithRequired(x => x.User).HasForeignKey(x => x.UserId).WillCascadeOnDelete(true);
        }
    }
}