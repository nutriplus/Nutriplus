namespace API.Models;

public class AppUser
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public Nutritionist? Nutritionist { get; set; }
    public Client? Client { get; set; }
    public Role Role { get; set; }
}