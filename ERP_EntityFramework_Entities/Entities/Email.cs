public class Email : BaseEntity
{
    public string EmailAddress { get; set; }

    public EmailType EmailType { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    public bool IsPrimaryEmail { get; set; }
}