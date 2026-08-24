using ERP_EntityFramework_Entities;

namespace ERP_EntityFramework_Business.Services
{
    public interface IUserService : IGenericService<User>
    {
        User Login(string username, string password);
    }
}
