using ERP_EntityFramework.DataAccess.Context;
using ERP_EntityFramework.DataAccess.DALs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_EntityFramework.DataAccess.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerDAL
    {
        public CustomerRepository(DataContext context) : base(context)
        {

        }
    }
}
