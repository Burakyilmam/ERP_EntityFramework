using ERP_EntityFramework.DataAccess.Context;
using ERP_EntityFramework.DataAccess.DALs;
using ERP_EntityFramework.DataAccess.Helpers;
using ERP_EntityFramework_Entities;
using System;

namespace ERP_EntityFramework.DataAccess.Repositories
{
    public class SessionRepository : GenericRepository<Session>, ISessionDAL
    {
        private readonly DataContext _context;

        public SessionRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public Session CreateSession(User user)
        {
            var session = new Session
            {
                UserId = user.Id,
                LoginDate = DateTime.Now,
                MachineName = Environment.MachineName,
                WindowsUsername = Environment.UserName,
                IPAddress = NetworkHelper.GetIPAddress(),
                LastActivityDate = DateTime.Now,
                IsActive = true,
                CreateDate = DateTime.Now
            };

            _context.Sessions.Add(session);
            _context.SaveChanges();

            return session;
        }
    }
}
