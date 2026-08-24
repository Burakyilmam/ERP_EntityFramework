using ERP_EntityFramework_Entities.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ERP_EntityFramework.DataAccess.Configurations
{
    public class UnitConfiguration : EntityTypeConfiguration<Unit>
    {
        public UnitConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Code).IsRequired().HasMaxLength(20);

            Property(x => x.Name).IsRequired().HasMaxLength(50);

            HasIndex(x => x.Code).IsUnique();
        }
    }
}