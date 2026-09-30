using ERP_EntityFramework.Core.Helpers;
using ERP_EntityFramework.DataAccess.DALs;
using ERP_EntityFramework_Business.Services;
using ERP_EntityFramework_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

public class UserManager : IUserService
{
    private readonly IUserDAL _userDAL;

    public UserManager(IUserDAL userDAL)
    {
        _userDAL = userDAL;
    }

    public void Add(User user)
    {
        _userDAL.Add(user);
    }

    public void Delete(User user)
    {
        _userDAL.Delete(user);
    }

    public User GetById(int id)
    {
        return _userDAL.GetById(id);
    }

    public List<User> ListAll()
    {
        return _userDAL.ListAll();
    }

    public List<User> List(Expression<Func<User, bool>> filter = null, Func<IQueryable<User>,
                           IOrderedQueryable<User>> orderBy = null, int? take = null)
    {
        return _userDAL.List(filter, orderBy, take);
    }

    public void Update(User user)
    {
        _userDAL.Update(user);
    }

    public User Login(string username, string password)
    {
        User user = _userDAL.Login(username);

        if (user == null) return null;

        if (!PasswordHelper.VerifyPassword(password, user.PasswordHash)) return null;

        return user;
    }

    public bool UserExists(string username)
    {
        return _userDAL.UserExists(username);
    }

    public bool ResetPassword(string username, string newPassword)
    {
        User user = _userDAL.GetUserByUsername(username);

        if (user == null) return false;

        user.PasswordHash = PasswordHelper.HashPassword(newPassword);

        _userDAL.Update(user);

        return true;
    }

    public User GetUserByUsername(string username)
    {
        return _userDAL.GetUserByUsername(username);
    }

    public void UserAdd(User user)
    {
        if (UserExists(user.Username)) return;

        user.PasswordHash = PasswordHelper.HashPassword(user.PasswordHash);

        _userDAL.UserAdd(user);

        Role userRole = _userDAL.GetRoleByName("User");

        if (userRole == null)
        {
            userRole = new Role
            {
                Name = "User",
                CreateDate = DateTime.Now,
                CreatedBy = "SYSTEM",
                IsActive = true
            };

            _userDAL.AddRole(userRole);
        }

        _userDAL.AddUserRole(new UserRole
        {
            UserId = user.Id,
            RoleId = userRole.Id
        });
    }
}