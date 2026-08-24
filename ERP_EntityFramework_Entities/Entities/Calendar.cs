using ERP_EntityFramework_Entities;
using System;

public class Calendar : BaseEntity
{
    public DateTime CurrentDate { get; set; }
    public string Title { get; set; }
    public string Note { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}