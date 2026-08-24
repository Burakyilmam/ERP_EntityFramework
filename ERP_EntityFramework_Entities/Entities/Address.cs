public class Address : BaseEntity
{
    public string Country { get; set; }
    public string City { get; set; }
    public string District { get; set; }
    public string Neighborhood { get; set; }
    public string Street { get; set; }
    public string PostalCode { get; set; }

    public AddressType AddressType { get; set; }

    public bool IsPrimary { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}