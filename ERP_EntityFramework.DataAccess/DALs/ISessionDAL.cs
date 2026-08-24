using ERP_EntityFramework_Entities;

namespace ERP_EntityFramework.DataAccess.DALs
{
    public interface ISessionDAL : IGenericDAL<Session>
    {
        Session CreateSession(User user);
    }
}
