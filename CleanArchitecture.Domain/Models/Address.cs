namespace MyFakeDatabaseProject.Models;

public class Address
{
    public Guid Id { get; set; }
    public string StreetAddress1 { get; set; }
    public string StreetAddress2 { get; set; }
    public string State { get; set; }
    public int PostCode { get; set; }
    public string Country { get; set; }
    
}
