using ERP_EntityFramework_Entities;

namespace ERP_EntityFramework.DataAccess.DALs
{
    public interface IUserDAL : IGenericDAL<User>
    {
        User Login(string username);
    }
}
