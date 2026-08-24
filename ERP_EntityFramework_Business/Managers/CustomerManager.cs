using ERP_EntityFramework.DataAccess.DALs;
using ERP_EntityFramework_Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ERP_EntityFramework_Business.Managers
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDAL _customerDAL;

        public CustomerManager(ICustomerDAL customerDAL)
        {
            _customerDAL = customerDAL;
        }

        public void Add(Customer t)
        {
           _customerDAL.Add(t);
        }

        public void Delete(Customer t)
        {
           _customerDAL.Delete(t);
        }

        public Customer GetById(int Id)
        {
            return _customerDAL.GetById(Id);
        }

        public List<Customer> List(Expression<Func<Customer, bool>> filter = null, Func<IQueryable<Customer>, IOrderedQueryable<Customer>> orderBy = null, int? take = null)
        {
            return _customerDAL.List(filter, orderBy, take);
        }

        public List<Customer> ListAll()
        {
            return _customerDAL.ListAll();
        }

        public void Update(Customer t)
        {
            _customerDAL.Update(t);
        }
    }
}
