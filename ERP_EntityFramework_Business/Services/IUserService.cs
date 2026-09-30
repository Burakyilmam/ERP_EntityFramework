using ERP_EntityFramework_Entities;

namespace ERP_EntityFramework_Business.Services
{
    public interface IUserService : IGenericService<User>
    {
        User Login(string username, string password);
        bool UserExists(string username);
        User GetUserByUsername(string username);
        bool ResetPassword(string username, string newPassword);
        void UserAdd(User user);
    }
}
