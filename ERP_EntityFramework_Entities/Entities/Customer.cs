using ERP_EntityFramework_Entities.Enums;
using System;
using System.Collections.Generic;

public class Customer : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string CompanyName { get; set; }

    public string CustomerCode { get; set; }

    public CustomerType CustomerType { get; set; }

    public string TaxNumber { get; set; }

    public string Notes { get; set; }

    public ICollection<Phone> Phones { get; set; }
    public ICollection<Email> Emails { get; set; }
    public ICollection<Address> Addresses { get; set; }
}