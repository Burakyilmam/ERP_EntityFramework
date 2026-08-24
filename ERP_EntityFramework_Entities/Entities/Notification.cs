using ERP_EntityFramework_Entities;

public class Notification : BaseEntity
{
    public int UserId { get; set; }
    public User User { get; set; }

    public string Title { get; set; }
    public string Content { get; set; }

    public bool IsRead { get; set; }

    public string RelatedForm { get; set; }
    public int? RelatedRecordId { get; set; }

    public byte NotificationType { get; set; }
    public byte Priority { get; set; }
}