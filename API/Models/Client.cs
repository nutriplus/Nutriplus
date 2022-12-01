namespace API.Models;

public class Client
{
    public int Id { get; set; }
    public bool PasswordChanged { get; set; }
    public DateTime MyProperty { get; set; }
    public string PhoneNumber { get; set; }
    public float Height { get; set; }
    public Nutritionist? Nutritionist { get; set; }
    public AppUser AppUser { get; set; }
}
