using System.Collections.Generic;

public class Unit : BaseEntity
{
    public string Code { get; set; }
    public string Name { get; set; }

    public ICollection<Product> Products { get; set; }
}