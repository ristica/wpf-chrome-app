namespace Chrome.Models;

public class CustomerUiModel
{
    public Guid Id { get; set; }
    public required string Kundennummer { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
}