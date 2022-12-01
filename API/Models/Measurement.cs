namespace API.Models;

public class Measurement
{
    public int Id { get; set; }
    // public Client Client { get; set; }
    public float Weight { get; set; }
    public float FatPercentage { get; set; }
    public float Bmi { get; set; }
}
