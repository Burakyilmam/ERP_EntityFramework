public class Phone : BaseEntity
{
    public string PhoneNumber { get; set; }
    public string CountryCode { get; set; }

    public PhoneType PhoneType { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}