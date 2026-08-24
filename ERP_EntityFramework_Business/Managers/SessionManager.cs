using ERP_EntityFramework.DataAccess.DALs;
using ERP_EntityFramework_Business.Services;
using ERP_EntityFramework_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ERP_EntityFramework_Business.Managers
{
    public class SessionManager : ISessionService
    {
        private readonly ISessionDAL _sessionDAL;

        public SessionManager(ISessionDAL sessionDAL)
        {
            _sessionDAL = sessionDAL;
        }

        public void Add(Session t)
        {
            _sessionDAL.Add(t);
        }

        public void Delete(Session t)
        {
            _sessionDAL.Delete(t);
        }

        public Session GetById(int Id)
        {
            return _sessionDAL.GetById(Id);
        }

        public List<Session> List(Expression<Func<Session, bool>> filter = null, Func<IQueryable<Session>, IOrderedQueryable<Session>> orderBy = null, int? take = null)
        {
            return _sessionDAL.List(filter, orderBy, take);
        }

        public List<Session> ListAll()
        {
            return _sessionDAL.ListAll();
        }

        public void Update(Session t)
        {
            _sessionDAL.Update(t);
        }

        public Session CreateSession(User user)
        {
            return _sessionDAL.CreateSession(user);
        }

        public void LogoutSession(Session session)
        {
            if (session == null) return;

            session.IsActive = false;
            session.LogoutDate = DateTime.Now;
            session.LastActivityDate = DateTime.Now;

            _sessionDAL.Update(session);
        }

    }
}
