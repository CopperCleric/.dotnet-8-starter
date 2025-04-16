namespace Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Mail { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Skillsets { get; set; } = string.Empty;
    public string Hobby { get; set; } = string.Empty;
}
