using ERP_EntityFramework_Entities;
using ERP_EntityFramework_Entities.Entities;
using System;
using System.Collections.Generic;

public class Employee : BaseEntity
{
    public string EmployeeCode { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string NationalId { get; set; }

    public DateTime? BirthDate { get; set; }

    public DateTime HireDate { get; set; }
    public DateTime? TerminationDate { get; set; }

    public int JobId { get; set; } 
    public Job Job { get; set; }

    public int DepartmentId { get; set; }
    public Department Department { get; set; }

    public int? UserId { get; set; }
    public User User { get; set; }

    public ICollection<Phone> Phones { get; set; }
    public ICollection<Email> Emails { get; set; }
}