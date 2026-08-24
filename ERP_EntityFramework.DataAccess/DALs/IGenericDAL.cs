using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ERP_EntityFramework.DataAccess.DALs
{
    public interface IGenericDAL<T> where T : class
    {
        List<T> ListAll();
        T GetById(int Id);
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        List<T> List(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, int? take = null);
    }
}
