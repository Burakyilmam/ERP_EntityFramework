using System.Collections.Generic;

namespace ERP_EntityFramework_Entities.Entities
{
    public class Job : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
