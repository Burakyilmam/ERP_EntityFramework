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


        public User Login(string username)
        {
            return _context.Users.FirstOrDefault(x => x.Username == username);
        }
    }
}
