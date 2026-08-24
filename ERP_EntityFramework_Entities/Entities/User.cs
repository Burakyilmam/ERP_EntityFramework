using System.Collections.Generic;

namespace ERP_EntityFramework_Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
