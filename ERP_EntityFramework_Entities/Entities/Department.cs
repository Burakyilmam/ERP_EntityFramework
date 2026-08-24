using System.Collections.Generic;

public class Department : BaseEntity
{
    public string Code { get; set; }
    public string Name { get; set; }

    public ICollection<Employee> Employees { get; set; }
}