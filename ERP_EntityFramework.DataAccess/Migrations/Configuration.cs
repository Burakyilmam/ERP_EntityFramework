namespace ERP_EntityFramework.DataAccess.Migrations
{
    using ERP_EntityFramework.Core.Helpers;
    using ERP_EntityFramework_Entities;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context.DataContext context)
        {
            context.Roles.AddOrUpdate(
                r => r.Name,
                new Role
                {
                    Name = "Admin",
                    CreateDate = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    IsActive = true
                },
                new Role
                {
                    Name = "User",
                    CreateDate = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    IsActive = true
                }
            );

            context.SaveChanges();

            context.Users.AddOrUpdate(
                u => u.Username,
                new User
                {
                    Username = "admin",
                    PasswordHash = PasswordHelper.HashPassword("123456"),
                    CreateDate = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    IsActive = true
                }
            );

            context.SaveChanges();

            var adminUser = context.Users.FirstOrDefault(x => x.Username == "admin");
            var adminRole = context.Roles.FirstOrDefault(x => x.Name == "Admin");

            if (adminUser != null && adminRole != null)
            {
                bool adminHasRole = context.UserRoles.Any(x => x.UserId == adminUser.Id && x.RoleId == adminRole.Id);

                if (!adminHasRole)
                {
                    context.UserRoles.Add(new UserRole
                    {
                        UserId = adminUser.Id,
                        RoleId = adminRole.Id
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}