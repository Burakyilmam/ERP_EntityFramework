using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_EntityFramework_Entities.Entities
{
    public class Category : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
