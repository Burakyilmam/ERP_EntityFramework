using ERP_EntityFramework_Entities.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ERP_EntityFramework.DataAccess.Configurations
{
    public class JobConfiguration : EntityTypeConfiguration<Job>
    {
        public JobConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Code).IsRequired().HasMaxLength(50);

            Property(x => x.Name).IsRequired().HasMaxLength(150);

            HasIndex(x => x.Code).IsUnique();
        }
    }
}