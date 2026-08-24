namespace ERP_EntityFramework.DataAccess.Migrations
{
    using ERP_EntityFramework.Core.Helpers;
    using ERP_EntityFramework.DataAccess.Context;
    using ERP_EntityFramework_Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ERP_EntityFramework.DataAccess.Context.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataContext context)
        {
            var adminRole = context.Roles.FirstOrDefault(x => x.Name == "Admin");

            if (adminRole == null)
            {
                adminRole = new Role
                {
                    Name = "Admin",
                    CreateDate = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    IsActive = true
                };

                context.Roles.Add(adminRole);
                context.SaveChanges();
            }

            var adminUser = context.Users.FirstOrDefault(x => x.Username == "admin");

            if (adminUser == null)
            {
                adminUser = new User
                {
                    Username = "admin",
                    PasswordHash = PasswordHelper.HashPassword("123456"),
                    CreateDate = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    IsActive = true
                };

                context.Users.Add(adminUser);
                context.SaveChanges();
            }

            bool hasRole = context.UserRoles.Any(x => x.UserId == adminUser.Id && x.RoleId == adminRole.Id);

            if (!hasRole)
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
