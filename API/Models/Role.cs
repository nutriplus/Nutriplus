namespace API.Models;

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }
    public AppUser AppUser { get; set; }
}
