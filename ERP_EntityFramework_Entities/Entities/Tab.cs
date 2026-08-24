using System;

namespace ERP_EntityFramework_Entities
{
    public class Tab : BaseEntity
    {
        public string TabName { get; set; }
        public string FormNo { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime FirstOpenDate { get; set; }
        public int OpenCount { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
