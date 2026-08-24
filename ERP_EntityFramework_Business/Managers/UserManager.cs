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
}