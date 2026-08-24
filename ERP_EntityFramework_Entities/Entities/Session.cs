using ERP_EntityFramework_Entities;
using System;
using System.Collections.Generic;

public class Session : BaseEntity
{
    public int? UserId { get; set; }
    public User User { get; set; }

    public string MachineName { get; set; }
    public string WindowsUsername { get; set; }
    public string IPAddress { get; set; }

    public DateTime LoginDate { get; set; }
    public DateTime? LogoutDate { get; set; }
    public DateTime? LastActivityDate { get; set; }
}