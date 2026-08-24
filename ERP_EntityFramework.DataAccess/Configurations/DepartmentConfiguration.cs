using System.Data.Entity.ModelConfiguration;

namespace ERP_EntityFramework.DataAccess.Configurations
{
    public class DepartmentConfiguration : EntityTypeConfiguration<Department>
    {
        public DepartmentConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Code).IsRequired().HasMaxLength(50);

            Property(x => x.Name).IsRequired().HasMaxLength(150);

            HasIndex(x => x.Code).IsUnique();
        }
    }
}