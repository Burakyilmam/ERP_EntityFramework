using ERP_EntityFramework.Core.Helpers;
using ERP_EntityFramework.DataAccess.Context;
using ERP_EntityFramework.DataAccess.DALs;
using ERP_EntityFramework_Entities;
using System.Linq;

namespace ERP_EntityFramework.DataAccess.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserDAL
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public void AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
        }

        public void AddUserRole(UserRole userRole)
        {
            _context.UserRoles.Add(userRole);
            _context.SaveChanges();
        }

        public Role GetRoleByName(string roleName)
        {
            return _context.Roles.FirstOrDefault(x => x.Name == roleName);
        }

        public User GetUserByUsername(string username)
        {
            return _context.Users.FirstOrDefault(x => x.Username == username);
        }

        public User Login(string username)
        {
            return _context.Users.FirstOrDefault(x => x.Username == username);
        }

        public void UserAdd(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public bool UserExists(string username)
        {
            return _context.Users.FirstOrDefault(x => x.Username == username) != null;
        }
    }
}
