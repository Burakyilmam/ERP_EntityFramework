using System.Data.Entity.ModelConfiguration;

namespace ERP_EntityFramework.DataAccess.Configurations
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.EmployeeCode).IsRequired().HasMaxLength(50);

            Property(x => x.FirstName).IsRequired().HasMaxLength(100);

            Property(x => x.LastName).IsRequired().HasMaxLength(100);

            Property(x => x.NationalId).HasMaxLength(20);

            HasIndex(x => x.EmployeeCode).IsUnique();

            HasIndex(x => x.NationalId).IsUnique();

            HasRequired(x => x.Department)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.DepartmentId)
                .WillCascadeOnDelete(false);

            HasRequired(x => x.Job)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.JobId)
                .WillCascadeOnDelete(false);

            HasOptional(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}