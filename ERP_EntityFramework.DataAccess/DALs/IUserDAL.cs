using ERP_EntityFramework_Entities;

namespace ERP_EntityFramework.DataAccess.DALs
{
    public interface IUserDAL : IGenericDAL<User>
    {
        User Login(string username);

        bool UserExists(string username);

        User GetUserByUsername(string username);

        void UserAdd(User user);

        void AddUserRole(UserRole userRole);

        Role GetRoleByName(string roleName);

        void AddRole(Role role);
    }
}
