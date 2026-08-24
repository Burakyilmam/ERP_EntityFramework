using ERP_EntityFramework_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_EntityFramework_Business.Services
{
    public interface ISessionService : IGenericService<Session>
    {
        Session CreateSession(User user);
        void LogoutSession(Session session);
    }
}
