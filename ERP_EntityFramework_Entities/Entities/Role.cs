using System.Collections;
using System.Collections.Generic;

namespace ERP_EntityFramework_Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
